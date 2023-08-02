using PKM.SecurityManager.Common;
using PKM.SecurityManager.DataLayer;
using PKM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.ServiceLayer
{
    public class UserService <T>: BaseService, IAssociationService<T> where T : UserModel
    {
       
        public UserService(CRMOrgService orgService)
        {
            OrgService = orgService;
        }

        public IEnumerable<T> FetchAllRecords(IEnumerable<Guid> selectedBUs)
        {
            return OrgService.GetUsers() as IEnumerable<T>;
        }

        public IEnumerable<BaseAssociationModel> FetchAssociationTableRecords(string entityLogicalName, List<Guid> entityIds)
        {
            IEnumerable<BaseAssociationModel> data = null;
            if (entityLogicalName == Constants.TeamTableName)
            {
                data = OrgService.GetTeamAssignedUsers(entityIds);
            }
            else if (entityLogicalName == Constants.FieldSecurityProfileTableName)
            {
                data = OrgService.GetFSPAssignedUsers(entityIds);
            }
            else if (entityLogicalName == Constants.RoleTableName)
            {
                data = OrgService.GetRoleAssignedUsers(entityIds);
            }

            return data;
        }

        public IEnumerable<T> InitialLoadAndCacheRelatedData(string fetchXML, string searchName)
        {
            return OrgService.InitialUserLoadAndCacheRelatedData(fetchXML, searchName) as IEnumerable<T>;
        }

        public void UpdatedAssociationTableRecords(IEnumerable<BaseAssociationModel> associations, bool assign)
        {
            OrgService.UpdateAssociations(associations, assign);
        }

        public IEnumerable<UserDirectAndTeamRolesOrFSPModel> GetUserDirectAndTeamRoles(Guid userId)
        {
            return OrgService.GetUserDirectAndTeamRoles(userId);
        }
        public IEnumerable<UserDirectAndTeamRolesOrFSPModel> GetUserDirectAndTeamFieldSecurityProfiles(Guid userId)
        {
            return OrgService.GetUserDirectAndTeamFieldSecurityProfiles(userId);
        }
    }
}
