using PKM.XRM.SecurityManager.DataLayer;
using PKM.XRM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.ServiceLayer
{
    public interface ICRMEntityViewService
    {
        IEnumerable<CRMEntityViewModel> GetEntityViews(string entityName, bool includeUserQueries);
    }
}
