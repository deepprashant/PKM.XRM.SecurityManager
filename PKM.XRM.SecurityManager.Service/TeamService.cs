using PKM.XRM.SecurityManager.Common;
using PKM.XRM.SecurityManager.DataLayer;
using PKM.XRM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.ServiceLayer
{
    public class TeamService<T> : BaseService, IAssociationService<T> where T : TeamModel
    {

        public TeamService(CRMOrgService orgService)
        {
            OrgService = orgService;
        }

        public IEnumerable<T> InitialLoadAndCacheRelatedData(string fetchXML, string teamName)
        {
            return OrgService.InitialTeamLoadAndCacheRelatedData(fetchXML, teamName) as IEnumerable<T>;
        }

        //public IEnumerable<T> FetchAllRecords(IEnumerable<Guid> selectedUsersBUs)
        //{
        //    return OrgService.GetTeams() as IEnumerable<T>;
        //}

        public IEnumerable<T> FetchAllRecords(Guid selectedBU)
        {
            return OrgService.GetTeams(selectedBU) as IEnumerable<T>;
        }

        public IEnumerable<BaseAssociationModel> FetchAssociationTableRecords(string entityLogicalName, List<Guid> entityIds)
        {
            IEnumerable<BaseAssociationModel> data = null;
            if (entityLogicalName == Constants.UserTableName)
            {
                data = OrgService.GetUserAssignedTeams(entityIds);
            }
            else if (entityLogicalName == Constants.FieldSecurityProfileTableName)
            {
                data = OrgService.GetFSPAssignedTeams(entityIds);
            }
            else if (entityLogicalName == Constants.RoleTableName)
            {
                data = OrgService.GetRoleAssignedTeams(entityIds);
            }

            return data;
        }

        public void UpdatedAssociationTableRecords(IEnumerable<BaseAssociationModel> associations, bool assign)
        {
            OrgService.UpdateAssociations(associations, assign);
        }
    }
}
