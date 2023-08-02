using PKM.SecurityManager.DataLayer;
using PKM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.ServiceLayer
{
    public interface ICRMEntityViewService
    {
        IEnumerable<CRMEntityViewModel> GetEntityViews(string entityName, bool includeUserQueries);
    }
}
