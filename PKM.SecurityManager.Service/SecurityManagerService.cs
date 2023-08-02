using PKM.SecurityManager.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.ServiceLayer
{
    public class SecurityManagerService : ISecurityManagerService
    {
        public CRMOrgService CrmService { get; set; }

        public SecurityManagerService(CRMOrgService crmService)
        {
            CrmService = crmService;
        }

        public void InitialDataLoad()
        {
            CrmService.InitialTeamRoleFSPLoad();
        }
    }
}
