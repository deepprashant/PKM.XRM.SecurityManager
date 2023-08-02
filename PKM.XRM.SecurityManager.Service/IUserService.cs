using PKM.XRM.SecurityManager.DataLayer;
using PKM.XRM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.ServiceLayer
{
    public interface IUserService
    {
        IEnumerable<UserModel> InitialUserLoadAndCacheRelatedData(string fetchXML, string userName);
    }
}
