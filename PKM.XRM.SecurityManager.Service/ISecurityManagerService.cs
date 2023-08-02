using PKM.XRM.SecurityManager.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.ServiceLayer
{
    public interface ISecurityManagerService
    {
        CRMOrgService CrmService { get; set; }

        void InitialDataLoad();
    }
}
