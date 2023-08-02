using System;

namespace PKM.SecurityManager.DataModelLayer
{
    public class BaseModel
    {
        public string EntityLogicalName { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string BusinessUnitName { get; set; }

        public Guid BusinessUnitId { get; set; }
    }
}
