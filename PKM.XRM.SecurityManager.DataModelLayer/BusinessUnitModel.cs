using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class BusinessUnitModel : BaseModel
    {
        public string ParentBusinessUnitName { get; set; }

        public Guid ParentBusinessUnitId { get; set; }

        public bool IsDisabled { get; set; }
    }
}
