using PKM.SecurityManager.DataLayer;
using PKM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.ServiceLayer
{
    public interface IUserService
    {
        IEnumerable<UserModel> InitialUserLoadAndCacheRelatedData(string fetchXML, string userName);
    }
}
