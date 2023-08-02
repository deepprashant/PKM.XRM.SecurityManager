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
    public class RoleService<T> : BaseService, IAssociationService<T> where T : RoleModel
    {

        public RoleService(CRMOrgService orgService)
        {
            OrgService = orgService;
        }


        public IEnumerable<T> FetchAllRecords(IEnumerable<Guid> selectedBUs)
        {
            return OrgService.GetBURoles(selectedBUs) as IEnumerable<T>;
        }

        public IEnumerable<BaseAssociationModel> FetchAssociationTableRecords(string entityLogicalName, List<Guid> entityIds)
        {
            IEnumerable<BaseAssociationModel> data = null;
            if (entityLogicalName == Constants.UserTableName)
            {
                data = OrgService.GetUserAssignedRoles(entityIds);
            }
            else if (entityLogicalName == Constants.TeamTableName)
            {
                data = OrgService.GetTeamAssignedRoles(entityIds);
            }

            return data;
        }

        public IEnumerable<T> InitialLoadAndCacheRelatedData(string fetchXML, string searchName)
        {
            return OrgService.InitialRoleLoadAndCacheRelatedData(new Guid(fetchXML), searchName) as IEnumerable<T>;
        }

        public void UpdatedAssociationTableRecords(IEnumerable<BaseAssociationModel> associations, bool assign)
        {
            OrgService.UpdateAssociations(associations, assign);
        }

        public IEnumerable<BusinessUnitModel> GetBusinessUnits()
        {
            return OrgService.GetBusinessUnits();
        }
    }
}
