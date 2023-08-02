using PKM.SecurityManager.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.ServiceLayer
{
    public interface ISecurityManagerService
    {
        CRMOrgService CrmService { get; set; }

        void InitialDataLoad();
    }
}
