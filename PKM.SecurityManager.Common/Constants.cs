using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKM.SecurityManager.Common
{
    public class Constants
    {
        public const string UserSecurityManagerView = "UserSecurityManagerView";
        public const string TeamSecurityManagerView = "TeamSecurityManagerView";
        public const string FieldSecurityProfileManagerView = "FieldSecurityProfileManagerView";
        public const string SecurityRoleManagerView = "SecurityRoleManagerView";
        public const string SecurityReportsView = "SecurityReportsView";
        public const string CloseTool = "CloseTool";
        public const string MultiSelectRoles = "Security Roles";
        public const string MultiSelectTeams = "Teams";
        public const string MultiSelectFSPs = "Field Security Profiles";
        public const string MultiSelectUsers = "Users";
        public const string UserRoleAssociationTable = "systemuserroles";
        public const string UserTeamAssociationTable = "teammembership";
        public const string UserFSPAssociationTable = "systemuserprofiles";
        public const string TeamRoleAssociationTable = "teamroles";
        public const string TeamFSPAssociationTable = "teamprofiles";

        public const string UserTableName = "systemuser";
        public const string TeamTableName = "team";
        public const string FieldSecurityProfileTableName = "fieldsecurityprofile";
        public const string RoleTableName = "role";
    }
}
