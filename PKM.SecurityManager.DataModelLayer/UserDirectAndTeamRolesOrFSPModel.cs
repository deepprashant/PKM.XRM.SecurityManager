using System;

namespace PKM.SecurityManager.DataModelLayer
{
    public class UserDirectAndTeamRolesOrFSPModel
    {
        public string EntityLogicalName { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid BusinessUnitId { get; set; }

        public string BusinessUnitName { get; set; }

        public Guid TeamId { get; set; }

        public string TeamName { get; set; }

        public Guid TeamBusinessUnitId { get; set; }

        public string TeamBusinessUnitName { get; set; }
    }
}
