using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using PKM.XRM.SecurityManager.DataModelLayer;
using PKM.XRM.SecurityManager.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.DataLayer
{
    public class CRMOrgService
    {
        List<BusinessUnitModel> cachedBUs;
        List<UserModel> cachedUsers;
        IEnumerable<RoleModel> cachedRoles;
        IEnumerable<TeamModel> cachedTeams;
        IEnumerable<FSPModel> cachedFSPs;

        IEnumerable<BaseAssociationModel> cachedUserRoles;
        IEnumerable<BaseAssociationModel> cachedUserTeams;
        IEnumerable<BaseAssociationModel> cachedUserFSPs;
        IEnumerable<BaseAssociationModel> cachedTeamRoles;
        IEnumerable<BaseAssociationModel> cachedTeamUsers;
        IEnumerable<BaseAssociationModel> cachedTeamFSPs;
        IEnumerable<BaseAssociationModel> cachedFSPUsers;
        IEnumerable<BaseAssociationModel> cachedFSPTeams;
        IEnumerable<BaseAssociationModel> cachedRoleUsers;
        IEnumerable<BaseAssociationModel> cachedRoleTeams;

        IOrganizationService orgService;

        public CRMOrgService(IOrganizationService service)
        {
            orgService = service;
        }

        private EntityCollection FetchCRMRecords(QueryExpression query, int recordPerPage = 0, bool fethcOnlyFirstPage = false)
        {
            List<Entity> records = new List<Entity>();
            query.PageInfo = new PagingInfo();
            query.PageInfo.PageNumber = 1;
            if (recordPerPage > 0)
                query.PageInfo.Count = recordPerPage;

            while (true)
            {
                var returnCollections = orgService.RetrieveMultiple(query);
                if (returnCollections.Entities.Count >= 1)
                {
                    records.AddRange(returnCollections.Entities);
                }

                if (returnCollections.MoreRecords && !fethcOnlyFirstPage)
                {
                    query.PageInfo.PageNumber++;
                    query.PageInfo.PagingCookie = returnCollections.PagingCookie;
                }
                else
                {
                    break;
                }
            }

            EntityCollection data = new EntityCollection(records);
            return data;
        }
        private EntityCollection GetSavedQueries(string entityLogicalName)
        {
            QueryExpression query = new QueryExpression("savedquery");
            query.ColumnSet.AddColumns("name", "fetchxml", "statuscode");
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entityLogicalName);
            return FetchCRMRecords(query);
        }
        private EntityCollection GetUserQueries(string entityLogicalName)
        {
            QueryExpression query = new QueryExpression("userquery");
            query.ColumnSet.AddColumns("name", "fetchxml", "statuscode");
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entityLogicalName);
            return FetchCRMRecords(query);
        }
        private void UpdatedAssociation(EntityReferenceCollection firstEntityRecords, EntityReferenceCollection secondEntityRecords, bool assign, string relationshipName)
        {
            if (firstEntityRecords.Count > 0 && secondEntityRecords.Count > 0)
            {
                var primaryEntityRecords = firstEntityRecords.Count < secondEntityRecords.Count ? firstEntityRecords : secondEntityRecords;
                var otherEntityRecords = firstEntityRecords.Count < secondEntityRecords.Count ? secondEntityRecords : firstEntityRecords;

                foreach (var record in primaryEntityRecords)
                {
                    try
                    {
                        if (assign)
                        {
                            orgService.Associate(
                                 record.LogicalName,
                                 record.Id,
                                 new Relationship(relationshipName),
                                 otherEntityRecords);
                        }
                        else
                        {
                            orgService.Disassociate(
                                 record.LogicalName,
                                 record.Id,
                                 new Relationship(relationshipName),
                                 otherEntityRecords);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
        private void UpdatedAssociation(IEnumerable<BaseAssociationModel> associations, bool assign, string relationshipName)
        {
            var firstEntityRecords = associations.Select(a => a.PrimaryEntity).Distinct();
            var secondEntityRecords = associations.Select(a => a.OtherEntity).Distinct();

            var primaryEntityRecords = firstEntityRecords.Count() < secondEntityRecords.Count() ? firstEntityRecords : secondEntityRecords;
            var otherEntityRecords = firstEntityRecords.Count() < secondEntityRecords.Count() ? secondEntityRecords : firstEntityRecords;
            EntityReferenceCollection otherEntityRecordsReference = new EntityReferenceCollection();
            foreach (var record in otherEntityRecords)
            {
                otherEntityRecordsReference.Add(new EntityReference(record.EntityLogicalName, record.Id));
            }

            foreach (var record in primaryEntityRecords)
            {
                try
                {
                    if (assign)
                    {
                        orgService.Associate(
                             record.EntityLogicalName,
                             record.Id,
                             new Relationship(relationshipName),
                             otherEntityRecordsReference);
                    }
                    else
                    {
                        orgService.Disassociate(
                             record.EntityLogicalName,
                             record.Id,
                             new Relationship(relationshipName),
                             otherEntityRecordsReference);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        private void FetchAndCacheBusinessUnits()
        {
            QueryExpression query = new QueryExpression("businessunit");
            query.ColumnSet.AddColumns("name", "businessunitid", "parentbusinessunitid", "isdisabled");

            var data = FetchCRMRecords(query);
            cachedBUs = (from en in data.Entities
                         select new BusinessUnitModel()
                         {
                             EntityLogicalName = en.LogicalName,
                             Id = en.Id,
                             Name = en.Contains("name") ? en["name"].ToString() : "--",
                             ParentBusinessUnitName = en.Contains("parentbusinessunitid") ? ((EntityReference)en["parentbusinessunitid"])?.Name : string.Empty,
                             ParentBusinessUnitId = en.Contains("parentbusinessunitid") ? ((EntityReference)en["parentbusinessunitid"]).Id : default(Guid),
                             IsDisabled = en.Contains("isdisabled") ? ((bool)en["isdisabled"]) : default(bool),
                         }).ToList();
        }
        private List<UserModel> FetchAndCacheUsers(QueryExpression query = null, bool cache = true)
        {
            if (query == null)
            {
                query = new QueryExpression("systemuser");
            }
            else
            {
                query.ColumnSet.Columns.Clear();
            }

            query.ColumnSet.AddColumns("systemuserid", "fullname", "businessunitid", "domainname", "firstname", "lastname", "title", "internalemailaddress", "accessmode", "isdisabled");


            //var data = this.FetchCRMRecords(query, 200, true);
            var data = this.FetchCRMRecords(query);
            var typedData = (from en in data.Entities
                             select new UserModel()
                             {
                                 EntityLogicalName = en.LogicalName,
                                 Id = en.Id,
                                 Name = en.Contains("fullname") ? en["fullname"].ToString() : string.Empty,
                                 DomainName = en.Contains("domainname") ? en["domainname"].ToString() : string.Empty,
                                 BusinessUnitName = ((EntityReference)en["businessunitid"]).Name,
                                 BusinessUnitId = ((EntityReference)en["businessunitid"]).Id,
                                 FirstName = en.Contains("firstname") ? en["firstname"].ToString() : string.Empty,
                                 LastName = en.Contains("lastname") ? en["lastname"].ToString() : string.Empty,
                                 Title = en.Contains("title") ? en["title"].ToString() : string.Empty,
                                 PrimaryEmail = en.Contains("internalemailaddress") ? en["internalemailaddress"].ToString() : string.Empty,
                                 AccessMode = en.Contains("accessmode") ? en.FormattedValues["accessmode"].ToString() : string.Empty,
                                 IsDisabled = en.Contains("isdisabled") ? en.FormattedValues["isdisabled"].ToString() : string.Empty
                             }).ToList();

            if (cache)
            {
                cachedUsers = typedData;
            }

            return typedData;
        }
        private List<TeamModel> FetchAndCacheTeams(QueryExpression query = null, bool cache = true)
        {
            if (query == null)
            {
                query = new QueryExpression("team");
            }

            query.ColumnSet.AddColumns("name", "businessunitid", "isdefault", "teamtype");

            var data = FetchCRMRecords(query);
            var typedData = (from en in data.Entities
                             select new TeamModel()
                             {
                                 EntityLogicalName = en.LogicalName,
                                 Id = en.Id,
                                 Name = en.Contains("name") ? en["name"].ToString() : "--",
                                 BusinessUnitName = ((EntityReference)en["businessunitid"]).Name,
                                 BusinessUnitId = ((EntityReference)en["businessunitid"]).Id,
                                 IsDefault = en.Contains("isdefault") ? ((bool)en["isdefault"]) : default(bool),
                                 TeamType = en.Contains("teamtype") ? ((OptionSetValue)en["teamtype"]).Value : -1,
                             }).ToList();

            if (cache)
            {
                cachedTeams = typedData;
            }

            return typedData;
        }
        private List<RoleModel> FetchAndCacheRoles(Guid businessUnitId = default(Guid), bool cache = true, string roleName = default(string))
        {
            string[] excludeRoles = new string[] { "Support User" };
            QueryExpression query = new QueryExpression("role");
            query.ColumnSet.AddColumns("roleid", "name", "businessunitid");
            query.Criteria.AddCondition(new ConditionExpression("name", ConditionOperator.NotIn, excludeRoles));
            if (businessUnitId != null && businessUnitId != Guid.Empty)
            {
                query.Criteria.AddCondition(new ConditionExpression("businessunitid", ConditionOperator.Equal, businessUnitId));
            }

            if (!string.IsNullOrWhiteSpace(roleName))
            {
                query.Criteria.AddCondition("name", ConditionOperator.Like, $"%{roleName}%");
            }

            var data = FetchCRMRecords(query);
            var typedData = (from en in data.Entities
                             select new RoleModel()
                             {
                                 EntityLogicalName = en.LogicalName,
                                 Id = en.Id,
                                 Name = en.Contains("name") ? en["name"].ToString() : "--",
                                 BusinessUnitName = ((EntityReference)en["businessunitid"]).Name,
                                 BusinessUnitId = ((EntityReference)en["businessunitid"]).Id
                             }).OrderBy(a => a.Name).ToList();

            if (cache)
            {
                cachedRoles = typedData;
            }

            return typedData;
        }
        private List<FSPModel> FetchAndCacheFieldSecurityProile(QueryExpression query = null, bool cache = true)
        {
            if (query == null)
            {
                query = new QueryExpression("fieldsecurityprofile");
            }

            query.ColumnSet.AddColumns("name");

            var data = FetchCRMRecords(query);
            var typedData = (from en in data.Entities
                             select new FSPModel()
                             {
                                 EntityLogicalName = en.LogicalName,
                                 Id = en.Id,
                                 Name = en.Contains("name") ? en["name"].ToString() : "--"
                             }).ToList();
            if (cache)
            {
                cachedFSPs = typedData;
            }

            return typedData;
        }
        private void FetchAndCacheUserRoles(List<Guid> users)
        {
            QueryExpression query = new QueryExpression("systemuserroles");
            if (users != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("systemuserid", ConditionOperator.In, users));
            }

            query.ColumnSet.AddColumns("roleid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedUserRoles = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "systemuser",
                                   PrimaryEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"]),
                                   OtherEntityLogicalName = "role",
                                   OtherEntity = cachedRoles.FirstOrDefault(a => a.Id == (Guid)en["roleid"])
                               }).ToList();
            cachedUserRoles = cachedUserRoles.Except(cachedUserRoles.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheUserTeams(List<Guid> users)
        {
            QueryExpression query = new QueryExpression("teammembership");
            if (users != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("systemuserid", ConditionOperator.In, users));
            }

            query.ColumnSet.AddColumns("teamid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedUserTeams = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "systemuser",
                                   PrimaryEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"]),
                                   OtherEntityLogicalName = "team",
                                   OtherEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"])
                               }).ToList();
            cachedUserTeams = cachedUserTeams.Except(cachedUserTeams.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheUserFSPs(List<Guid> userIds)
        {
            QueryExpression query = new QueryExpression("systemuserprofiles");
            if (userIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("systemuserid", ConditionOperator.In, userIds));
            }

            query.ColumnSet.AddColumns("fieldsecurityprofileid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedUserFSPs = (from en in data.Entities
                              select new BaseAssociationModel()
                              {
                                  EntityLogicalName = en.LogicalName,
                                  Id = en.Id,
                                  PrimaryEntityLogicalName = Constants.UserTableName,
                                  PrimaryEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"]),
                                  OtherEntityLogicalName = Constants.FieldSecurityProfileTableName,
                                  OtherEntity = cachedFSPs.FirstOrDefault(a => a.Id == (Guid)en["fieldsecurityprofileid"])
                              }).ToList();
            cachedUserFSPs = cachedUserFSPs.Except(cachedUserFSPs.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheTeamRoles(List<Guid> teamIds)
        {
            QueryExpression query = new QueryExpression("teamroles");
            if (teamIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("teamid", ConditionOperator.In, teamIds));
            }

            query.ColumnSet.AddColumns("roleid", "teamid");

            var data = FetchCRMRecords(query);
            cachedTeamRoles = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "team",
                                   PrimaryEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"]),
                                   OtherEntityLogicalName = "role",
                                   OtherEntity = cachedRoles.FirstOrDefault(a => a.Id == (Guid)en["roleid"])
                               }).ToList();
            cachedTeamRoles = cachedTeamRoles.Except(cachedTeamRoles.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheUserTeamRoles(List<Guid> userIds)
        {
            QueryExpression query = new QueryExpression("teamroles");
            var query_teammembership = query.AddLink("teammembership", "teamid", "teamid");
            query_teammembership.LinkCriteria.AddCondition(new ConditionExpression("systemuserid", ConditionOperator.In, userIds));
            query.ColumnSet.AddColumns("roleid", "teamid");

            var data = FetchCRMRecords(query);
            cachedTeamRoles = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "team",
                                   PrimaryEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"]),
                                   OtherEntityLogicalName = "role",
                                   OtherEntity = cachedRoles.FirstOrDefault(a => a.Id == (Guid)en["roleid"])
                               }).ToList();
            cachedTeamRoles = cachedTeamRoles.Except(cachedTeamRoles.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheTeamUsers(List<Guid> teamIds)
        {
            QueryExpression query = new QueryExpression("teammembership");
            if (teamIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("teamid", ConditionOperator.In, teamIds));
            }

            query.ColumnSet.AddColumns("teamid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedTeamUsers = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "team",
                                   PrimaryEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"]),
                                   OtherEntityLogicalName = "systemuser",
                                   OtherEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"])
                               }).ToList();
            cachedTeamUsers = cachedTeamUsers.Except(cachedTeamUsers.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheTeamFSPs(List<Guid> teamIds)
        {
            QueryExpression query = new QueryExpression("teamprofiles");
            if (teamIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("teamid", ConditionOperator.In, teamIds));
            }

            query.ColumnSet.AddColumns("teamid", "fieldsecurityprofileid");

            var data = FetchCRMRecords(query);
            cachedTeamFSPs = (from en in data.Entities
                              select new BaseAssociationModel()
                              {
                                  EntityLogicalName = en.LogicalName,
                                  Id = en.Id,
                                  PrimaryEntityLogicalName = "team",
                                  PrimaryEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"]),
                                  OtherEntityLogicalName = "fieldsecurityprofile",
                                  OtherEntity = cachedFSPs.FirstOrDefault(a => a.Id == (Guid)en["fieldsecurityprofileid"])
                              }).ToList();
        }
        private void FetchAndCacheUserTeamFSPs(List<Guid> userIds)
        {
            QueryExpression query = new QueryExpression("teamprofiles");
            var query_teammembership = query.AddLink("teammembership", "teamid", "teamid");
            query_teammembership.LinkCriteria.AddCondition(new ConditionExpression("systemuserid", ConditionOperator.In, userIds));
            query.ColumnSet.AddColumns("teamid", "fieldsecurityprofileid");

            var data = FetchCRMRecords(query);
            cachedTeamFSPs = (from en in data.Entities
                              select new BaseAssociationModel()
                              {
                                  EntityLogicalName = en.LogicalName,
                                  Id = en.Id,
                                  PrimaryEntityLogicalName = "team",
                                  PrimaryEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"]),
                                  OtherEntityLogicalName = "fieldsecurityprofile",
                                  OtherEntity = cachedFSPs.FirstOrDefault(a => a.Id == (Guid)en["fieldsecurityprofileid"])
                              }).ToList();
        }
        private void FetchAndCacheFSPUsers(List<Guid> fspIds)
        {
            QueryExpression query = new QueryExpression("systemuserprofiles");
            if (fspIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("fieldsecurityprofileid", ConditionOperator.In, fspIds));
            }

            query.ColumnSet.AddColumns("fieldsecurityprofileid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedFSPUsers = (from en in data.Entities
                              select new BaseAssociationModel()
                              {
                                  EntityLogicalName = en.LogicalName,
                                  Id = en.Id,
                                  PrimaryEntityLogicalName = Constants.FieldSecurityProfileTableName,
                                  PrimaryEntity = cachedFSPs.FirstOrDefault(a => a.Id == (Guid)en["fieldsecurityprofileid"]),
                                  OtherEntityLogicalName = Constants.UserTableName,
                                  OtherEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"])
                              }).ToList();
            //cachedFSPUsers = cachedFSPUsers.Except(cachedFSPUsers.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheFSPTeams(List<Guid> fspIds)
        {
            QueryExpression query = new QueryExpression("teamprofiles");
            if (fspIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("fieldsecurityprofileid", ConditionOperator.In, fspIds));
            }

            query.ColumnSet.AddColumns("teamid", "fieldsecurityprofileid");

            var data = FetchCRMRecords(query);
            cachedFSPTeams = (from en in data.Entities
                              select new BaseAssociationModel()
                              {
                                  EntityLogicalName = en.LogicalName,
                                  Id = en.Id,
                                  PrimaryEntityLogicalName = "fieldsecurityprofile",
                                  PrimaryEntity = cachedFSPs.FirstOrDefault(a => a.Id == (Guid)en["fieldsecurityprofileid"]),
                                  OtherEntityLogicalName = "team",
                                  OtherEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"])
                              }).ToList();
        }
        private void FetchAndCacheRoleUsers(List<Guid> roleIds)
        {
            QueryExpression query = new QueryExpression("systemuserroles");
            if (roleIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("roleid", ConditionOperator.In, roleIds));
            }

            query.ColumnSet.AddColumns("roleid", "systemuserid");

            var data = FetchCRMRecords(query);
            cachedRoleUsers = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "role",
                                   PrimaryEntity = cachedRoles.FirstOrDefault(a => a.Id == (Guid)en["roleid"]),
                                   OtherEntityLogicalName = "systemuser",
                                   OtherEntity = cachedUsers.FirstOrDefault(a => a.Id == (Guid)en["systemuserid"]),
                               }).ToList();
            cachedRoleUsers = cachedRoleUsers.Except(cachedRoleUsers.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }
        private void FetchAndCacheRoleTeams(List<Guid> roleIds)
        {
            QueryExpression query = new QueryExpression("teamroles");
            if (roleIds != null)
            {
                query.Criteria.AddCondition(new ConditionExpression("roleid", ConditionOperator.In, roleIds));
            }

            query.ColumnSet.AddColumns("roleid", "teamid");

            var data = FetchCRMRecords(query);
            cachedRoleTeams = (from en in data.Entities
                               select new BaseAssociationModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   PrimaryEntityLogicalName = "role",
                                   PrimaryEntity = cachedRoles.FirstOrDefault(a => a.Id == (Guid)en["roleid"]),
                                   OtherEntityLogicalName = "team",
                                   OtherEntity = cachedTeams.FirstOrDefault(a => a.Id == (Guid)en["teamid"])
                               }).ToList();
            cachedRoleTeams = cachedRoleTeams.Except(cachedRoleTeams.Where(a => a.PrimaryEntity == null || a.OtherEntity == null));
        }


        public void InitialTeamRoleFSPLoad()
        {
            var tasks = new List<Task>();
            tasks.Add(Task.Factory.StartNew(() => FetchAndCacheBusinessUnits()));
            tasks.Add(Task.Factory.StartNew(() => FetchAndCacheRoles(default(Guid), true)));
            tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUsers(null, true)));
            tasks.Add(Task.Factory.StartNew(() => FetchAndCacheTeams(null, true)));
            tasks.Add(Task.Factory.StartNew(() => FetchAndCacheFieldSecurityProile(null, true)));
            Task.WaitAll(tasks.ToArray());
        }
        public IEnumerable<CRMEntityViewModel> FetchSystemUserSavedAndUserQueries(string entityLogicalName, bool includeUserQueries)
        {
            var tempData = GetSavedQueries(entityLogicalName);
            var data = (from en in tempData.Entities
                        select new CRMEntityViewModel()
                        {
                            EntityLogicalName = en.LogicalName,
                            Id = en.Id,
                            Name = en.Contains("name") ? en["name"].ToString() : "--",
                            FetchXML = en.Contains("fetchxml") ? en["fetchxml"].ToString() : string.Empty
                        }).ToList();
            if (includeUserQueries)
            {
                tempData = GetUserQueries(entityLogicalName);
                data.AddRange((from en in tempData.Entities
                               select new CRMEntityViewModel()
                               {
                                   EntityLogicalName = en.LogicalName,
                                   Id = en.Id,
                                   Name = en.Contains("name") ? $"*{en["name"].ToString()}" : "*--",
                                   FetchXML = en.Contains("fetchxml") ? en["fetchxml"].ToString() : string.Empty
                               }).ToList());
            }

            return data;
        }
        public IEnumerable<BusinessUnitModel> GetBusinessUnits()
        {
            return cachedBUs.OrderBy(a => a.Name).ToList();
        }


        public List<UserModel> InitialUserLoadAndCacheRelatedData(string fetchXML, string userName)
        {
            QueryExpression query;
            if (string.IsNullOrEmpty(fetchXML))
            {
                query = new QueryExpression("systemuser");
            }
            else
            {
                FetchXmlToQueryExpressionRequest req = new FetchXmlToQueryExpressionRequest() { FetchXml = fetchXML };
                var resp = (FetchXmlToQueryExpressionResponse)orgService.Execute(req);
                query = resp.Query;
            }

            if (!string.IsNullOrWhiteSpace(userName))
            {
                query.Criteria.AddCondition("fullname", ConditionOperator.Like, $"%{userName}%");
            }

            var data = this.FetchAndCacheUsers(query, false);
            var userIds = data.Select(a => a.Id).ToList();
            if (data.Count > 0)
            {
                var tasks = new List<Task>();
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheBusinessUnits()));
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheRoles()));
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheTeams()));
                ////tasks.Add(Task.Factory.StartNew(() => LoadCRMFieldSecurity()));
                //Task.WaitAll(tasks.ToArray());
                //tasks.Clear();
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUserRoles(userIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUserTeams(userIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUserFSPs(userIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUserTeamRoles(userIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUserTeamFSPs(userIds)));
                Task.WaitAll(tasks.ToArray());
            }

            return data;
        }
        public IEnumerable<UserModel> GetUsers()
        {
            return cachedUsers;
        }
        public IEnumerable<BaseAssociationModel> GetTeamAssignedUsers(List<Guid> teamIds)
        {
            return (from teamUsers in cachedTeamUsers
                    join teamId in teamIds on teamUsers.PrimaryEntity.Id equals teamId
                    select teamUsers);
        }
        public IEnumerable<UserDirectAndTeamRolesOrFSPModel> GetUserDirectAndTeamRoles(Guid userId)
        {
            var userRoles = from cur in cachedUserRoles
                            where cur.PrimaryEntity.Id == userId
                            select new UserDirectAndTeamRolesOrFSPModel()
                            {
                                Id = cur.OtherEntity.Id,
                                EntityLogicalName = cur.OtherEntity.EntityLogicalName,
                                Name = cur.OtherEntity.Name,
                                BusinessUnitId = cur.OtherEntity.BusinessUnitId,
                                BusinessUnitName = cur.OtherEntity.BusinessUnitName
                            };

            var userTeamRoles = from cut in cachedUserTeams
                                where cut.PrimaryEntity.Id == userId
                                join ctr in cachedTeamRoles on cut.OtherEntity.Id equals ctr.PrimaryEntity.Id
                                select new UserDirectAndTeamRolesOrFSPModel()
                                {
                                    Id = ctr.OtherEntity.Id,
                                    EntityLogicalName = ctr.OtherEntity.EntityLogicalName,
                                    Name = ctr.OtherEntity.Name,
                                    BusinessUnitId = ctr.OtherEntity.BusinessUnitId,
                                    BusinessUnitName = ctr.OtherEntity.BusinessUnitName,
                                    TeamId = ctr.PrimaryEntity.Id,
                                    TeamName = ctr.PrimaryEntity.Name,
                                    TeamBusinessUnitId = ctr.PrimaryEntity.BusinessUnitId,
                                    TeamBusinessUnitName = ctr.PrimaryEntity.BusinessUnitName
                                };

            return userRoles.Union(userTeamRoles).OrderBy(a => a.Name);
        }
        public IEnumerable<UserDirectAndTeamRolesOrFSPModel> GetUserDirectAndTeamFieldSecurityProfiles(Guid userId)
        {
            var userFSPs = from cuf in cachedUserFSPs
                           where cuf.PrimaryEntity.Id == userId
                           select new UserDirectAndTeamRolesOrFSPModel()
                           {
                               Id = cuf.OtherEntity.Id,
                               EntityLogicalName = cuf.OtherEntity.EntityLogicalName,
                               Name = cuf.OtherEntity.Name,
                               BusinessUnitId = cuf.OtherEntity.BusinessUnitId,
                               BusinessUnitName = cuf.OtherEntity.BusinessUnitName
                           };

            var userTeamFSPs = from cut in cachedUserTeams
                               where cut.PrimaryEntity.Id == userId
                               join ctf in cachedTeamFSPs on cut.OtherEntity.Id equals ctf.PrimaryEntity.Id
                               select new UserDirectAndTeamRolesOrFSPModel()
                               {
                                   Id = ctf.OtherEntity.Id,
                                   EntityLogicalName = ctf.OtherEntity.EntityLogicalName,
                                   Name = ctf.OtherEntity.Name,
                                   BusinessUnitId = ctf.OtherEntity.BusinessUnitId,
                                   BusinessUnitName = ctf.OtherEntity.BusinessUnitName,
                                   TeamId = ctf.PrimaryEntity.Id,
                                   TeamName = ctf.PrimaryEntity.Name,
                                   TeamBusinessUnitId = ctf.PrimaryEntity.BusinessUnitId,
                                   TeamBusinessUnitName = ctf.PrimaryEntity.BusinessUnitName
                               };

            return userFSPs.Union(userTeamFSPs).OrderBy(a => a.Name);
        }
        public IEnumerable<BaseAssociationModel> GetFSPAssignedUsers(List<Guid> fspIds)
        {
            return (from fspUsers in cachedFSPUsers
                    join fspId in fspIds on fspUsers.PrimaryEntity.Id equals fspId
                    select fspUsers);
        }
        public IEnumerable<BaseAssociationModel> GetRoleAssignedUsers(List<Guid> roleIds)
        {
            return (from roleUser in cachedRoleUsers
                    join roleId in roleIds on roleUser.PrimaryEntity.Id equals roleId
                    select roleUser);
        }


        public IEnumerable<TeamModel> InitialTeamLoadAndCacheRelatedData(string fetchXML, string teamName)
        {
            QueryExpression query;
            if (string.IsNullOrEmpty(fetchXML))
            {
                query = new QueryExpression("team");
            }
            else
            {
                FetchXmlToQueryExpressionRequest req = new FetchXmlToQueryExpressionRequest() { FetchXml = fetchXML };
                var resp = (FetchXmlToQueryExpressionResponse)orgService.Execute(req);
                query = resp.Query;
            }

            if (!string.IsNullOrWhiteSpace(teamName))
            {
                query.Criteria.AddCondition("name", ConditionOperator.Like, $"%{teamName}%");
            }

            var data = this.FetchAndCacheTeams(query, false);
            var teamsIds = cachedTeams.Select(a => a.Id).ToList();
            if (teamsIds.Count > 0)
            {
                var tasks = new List<Task>();
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheBusinessUnits()));
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheRoles()));
                //tasks.Add(Task.Factory.StartNew(() => FetchAndCacheUsers()));
                ////tasks.Add(Task.Factory.StartNew(() => LoadCRMFieldSecurity()));
                //Task.WaitAll(tasks.ToArray());
                //tasks.Clear();
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheTeamRoles(teamsIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheTeamUsers(teamsIds)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheTeamFSPs(teamsIds)));
                //tasks.Add(Task.Factory.StartNew(() => LoadCRMUserFieldSecurity()));
                //tasks.Add(Task.Factory.StartNew(() => LoadCRMTeamFieldSecurity()));
                Task.WaitAll(tasks.ToArray());
            }

            return data;
        }
        public IEnumerable<TeamModel> GetTeams()
        {
            return cachedTeams;
        }
        public IEnumerable<BaseAssociationModel> GetUserAssignedTeams(List<Guid> selectedUserIds)
        {
            return (from userTeam in cachedUserTeams
                    join userId in selectedUserIds on userTeam.PrimaryEntity.Id equals userId
                    select userTeam);
        }
        public IEnumerable<BaseAssociationModel> GetFSPAssignedTeams(List<Guid> fspIds)
        {
            return (from fspTeam in cachedFSPTeams
                    join fspId in fspIds on fspTeam.PrimaryEntity.Id equals fspId
                    select fspTeam);
        }
        public IEnumerable<BaseAssociationModel> GetRoleAssignedTeams(List<Guid> roleIds)
        {
            return (from roleTeam in cachedRoleTeams
                    join roleId in roleIds on roleTeam.PrimaryEntity.Id equals roleId
                    select roleTeam);
        }


        public IEnumerable<RoleModel> InitialRoleLoadAndCacheRelatedData(Guid buId, string roleName)
        {
            var data = this.FetchAndCacheRoles(buId, false, roleName);
            var ids = data.Select(a => a.Id).ToList();
            if (ids.Count > 0)
            {
                var tasks = new List<Task>();
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheRoleUsers(ids)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheRoleTeams(ids)));
                Task.WaitAll(tasks.ToArray());
            }

            return data;
        }
        public IEnumerable<RoleModel> GetBURoles(IEnumerable<Guid> selectedUsersBUs)
        {
            return (from role in cachedRoles
                    join buId in selectedUsersBUs on role.BusinessUnitId equals buId
                    //orderby role.Name
                    select role);
        }
        public List<BaseAssociationModel> GetUserAssignedRoles(List<Guid> selectedUserIds)
        {
            return (from userRole in cachedUserRoles
                    join userId in selectedUserIds on userRole.PrimaryEntity.Id equals userId
                    select userRole).ToList();
        }
        public List<BaseAssociationModel> GetTeamAssignedRoles(List<Guid> selectedTeamIds)
        {
            return (from teamRole in cachedTeamRoles
                    join teamId in selectedTeamIds on teamRole.PrimaryEntity.Id equals teamId
                    select teamRole).ToList();
        }


        public IEnumerable<FSPModel> InitialFieldSecurityLoadAndCacheRelatedData(string fetchXML, string fieldSecurityName)
        {
            QueryExpression query;
            if (string.IsNullOrEmpty(fetchXML))
            {
                query = new QueryExpression("fieldsecurityprofile");
            }
            else
            {
                FetchXmlToQueryExpressionRequest req = new FetchXmlToQueryExpressionRequest() { FetchXml = fetchXML };
                var resp = (FetchXmlToQueryExpressionResponse)orgService.Execute(req);
                query = resp.Query;
            }

            if (!string.IsNullOrWhiteSpace(fieldSecurityName))
            {
                query.Criteria.AddCondition("name", ConditionOperator.Like, $"%{fieldSecurityName}%");
            }

            var data = this.FetchAndCacheFieldSecurityProile(query, false);
            var ids = data.Select(a => a.Id).ToList();
            if (ids.Count > 0)
            {
                var tasks = new List<Task>();
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheFSPUsers(ids)));
                tasks.Add(Task.Factory.StartNew(() => FetchAndCacheFSPTeams(ids)));
                Task.WaitAll(tasks.ToArray());
            }

            return data;
        }
        public IEnumerable<FSPModel> GetFieldSecurityProfiles()
        {
            return cachedFSPs;
        }
        public IEnumerable<BaseAssociationModel> GetUserAssignedFieldSecurityProfiless(List<Guid> userIds)
        {
            return (from userFSP in cachedUserFSPs
                    join userId in userIds on userFSP.PrimaryEntity.Id equals userId
                    select userFSP);
        }
        public IEnumerable<BaseAssociationModel> GetTeamAssignedFieldSecurityProfiless(List<Guid> teamIds)
        {
            return (from teamFSP in cachedTeamFSPs
                    join teamId in teamIds on teamFSP.PrimaryEntity.Id equals teamId
                    select teamFSP);
        }



        // public void UpdatedUserSecurityRolesOrTeamsOrFSPs<T>(List<UserModel> users, List<T> otherEntities, bool assign) where T : BaseModel
        // {
        //EntityReferenceCollection usersReference = new EntityReferenceCollection();
        //EntityReferenceCollection othersReference = new EntityReferenceCollection();
        //List<Guid> otherIds = new List<Guid>();
        //List<Guid> userIds = new List<Guid>();
        //foreach (UserModel user in users)
        //{
        //    usersReference.Add(new EntityReference(user.EntityLogicalName, user.Id));
        //    userIds.Add(user.Id);
        //}

        //foreach (T role in otherEntities)
        //{
        //    othersReference.Add(new EntityReference(role.EntityLogicalName, role.Id));
        //    otherIds.Add(role.Id);
        //}

        //UpdatedAssociation(usersReference, othersReference, assign, "systemuserroles_association");

        //if (assign)
        //{
        //    foreach (UserModel user in users)
        //    {
        //        foreach (T entity in otherEntities)
        //        {
        //            if (entity.EntityLogicalName == "role")
        //            {
        //                cachedUserRoles.Add(new UserAssociation() { User = user, Role = entity as RoleModel });
        //            }
        //            else if (entity.EntityLogicalName == "team")
        //            {
        //                cachedUserTeams.Add(new UserTeamModel() { User = user, Team = entity as TeamModel });
        //            }
        //            else if (entity.EntityLogicalName == "fieldsecurityprofile")
        //            {

        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    if (otherEntities.First().EntityLogicalName == "role")
        //    {
        //        cachedUserRoles.RemoveAll(a => otherIds.Contains(a.Role.Id) && userIds.Contains(a.User.Id));
        //    }
        //    else if (otherEntities.First().EntityLogicalName == "team")
        //    {
        //        cachedUserTeams.RemoveAll(a => otherIds.Contains(a.Team.Id) && userIds.Contains(a.User.Id));
        //    }
        //    else if (otherEntities.First().EntityLogicalName == "fieldsecurityprofile")
        //    {

        //    }
        //}
        //}
        public void UpdateAssociations(IEnumerable<BaseAssociationModel> assoications, bool assign)
        {
            var associationLogicalName = assoications.First().EntityLogicalName;
            var associationPrimaryEntityName = assoications.First().PrimaryEntityLogicalName;
            UpdatedAssociation(assoications, assign, associationLogicalName + "_association");

            if (assign)
            {
                if (associationPrimaryEntityName == Constants.UserTableName)
                {
                    if (associationLogicalName == Constants.UserRoleAssociationTable)
                    {
                        cachedUserRoles = cachedUserRoles.Union(assoications);
                    }
                    else if (associationLogicalName == Constants.UserTeamAssociationTable)
                    {
                        cachedUserTeams = cachedUserTeams.Union(assoications);
                    }
                    else if (associationLogicalName == Constants.UserFSPAssociationTable)
                    {
                        cachedUserFSPs = cachedUserFSPs.Union(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.TeamTableName)
                {
                    if (associationLogicalName == Constants.TeamRoleAssociationTable)
                    {
                        cachedTeamRoles = cachedTeamRoles.Union(assoications);
                    }
                    else if (associationLogicalName == Constants.UserTeamAssociationTable)
                    {
                        cachedTeamUsers = cachedTeamUsers.Union(assoications);
                    }
                    else if (associationLogicalName == Constants.TeamFSPAssociationTable)
                    {
                        cachedTeamFSPs = cachedTeamFSPs.Union(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.FieldSecurityProfileTableName)
                {
                    if (associationLogicalName == Constants.UserFSPAssociationTable)
                    {
                        cachedFSPUsers = cachedFSPUsers.Union(assoications);
                    }
                    else if (associationLogicalName == Constants.TeamFSPAssociationTable)
                    {
                        cachedFSPTeams = cachedFSPTeams.Union(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.RoleTableName)
                {
                }
            }
            else
            {
                if (associationPrimaryEntityName == Constants.UserTableName)
                {
                    if (associationLogicalName == Constants.UserRoleAssociationTable)
                    {
                        cachedUserRoles = cachedUserRoles.Except(assoications).ToList();
                    }
                    else if (associationLogicalName == Constants.UserTeamAssociationTable)
                    {
                        cachedUserTeams = cachedUserTeams.Except(assoications);
                    }
                    else if (associationLogicalName == Constants.UserFSPAssociationTable)
                    {
                        cachedUserFSPs = cachedUserFSPs.Except(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.TeamTableName)
                {
                    if (associationLogicalName == Constants.TeamRoleAssociationTable)
                    {
                        cachedTeamRoles = cachedTeamRoles.Except(assoications).ToList();
                    }
                    else if (associationLogicalName == Constants.UserTeamAssociationTable)
                    {
                        cachedTeamUsers = cachedTeamUsers.Except(assoications);
                    }
                    else if (associationLogicalName == Constants.TeamFSPAssociationTable)
                    {
                        cachedTeamFSPs = cachedTeamFSPs.Except(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.FieldSecurityProfileTableName)
                {
                    if (associationLogicalName == Constants.UserFSPAssociationTable)
                    {
                        cachedFSPUsers = cachedFSPUsers.Except(assoications);
                    }
                    else if (associationLogicalName == Constants.TeamFSPAssociationTable)
                    {
                        cachedFSPTeams = cachedFSPTeams.Except(assoications);
                    }
                }
                else if (associationPrimaryEntityName == Constants.RoleTableName)
                {
                }
            }
        }
        //public void UpdatedTeamSecurityRolesOrUsersOrFSPs(IEnumerable<BaseAssociationModel> assoications, bool assign)
        //{
        //    var associationLogicalName = assoications.First().EntityLogicalName;
        //    UpdatedAssociation(assoications, assign, associationLogicalName + "_association");

        //    if (assign)
        //    {
        //        if (associationLogicalName == Constants.TeamRoleAssociationTable)
        //        {
        //            cachedTeamRoles = cachedTeamRoles.Union(assoications);
        //        }
        //        else if (associationLogicalName == Constants.TeamUserAssociationTable)
        //        {
        //            cachedTeamUsers = cachedTeamUsers.Union(assoications);
        //        }
        //        else if (associationLogicalName == Constants.TeamFSPAssociationTable)
        //        {

        //        }
        //    }
        //    else
        //    {
        //        if (associationLogicalName == Constants.TeamRoleAssociationTable)
        //        {
        //            cachedTeamRoles = cachedTeamRoles.Except(assoications).ToList();
        //        }
        //        else if (associationLogicalName == Constants.TeamUserAssociationTable)
        //        {
        //            cachedTeamUsers = cachedTeamUsers.Except(assoications);
        //        }
        //        else if (associationLogicalName == Constants.TeamFSPAssociationTable)
        //        {

        //        }
        //    }
        //}
    }
}
