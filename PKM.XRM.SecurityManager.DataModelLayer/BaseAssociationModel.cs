using System;

namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class BaseAssociationModel
    {
        public string EntityLogicalName { get; set; }
        public string PrimaryEntityLogicalName { get; set; }
        public string OtherEntityLogicalName { get; set; }

        public Guid Id { get; set; }

        public BaseModel PrimaryEntity { get; set; }

        public BaseModel OtherEntity { get; set; }
    }
}
