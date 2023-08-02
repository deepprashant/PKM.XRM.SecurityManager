using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public interface IUserSecurityManagerView
    {
        string UserNameSearchPhrase { get; }
        MultiSelectView SecurityRoleView { get; }
        MultiSelectView TeamView { get; }
        MultiSelectView FieldSecurityProfileView { get; }
        string SelectedUserEntityViewFetchXML { get; }
        int UserCount { set; }
        int DirectAndTeamRoleCount { set; }
        int DirectAndTeamFSPCount { set; }

        event EventHandler SearchUser;

        event EventHandler UserSelection;

        void SetUserEntityViewBindingSource(BindingSource userEntityViews);
        void SetUsersBindingSource(BindingSource users);
        void SetUserDirectAndTeamRolesBindingSource(BindingSource allRoles);
        void SetUserDirectAndTeamFSPsBindingSource(BindingSource allFsps);
        void Show();
        List<Guid> GetSelectedUseresId();
    }
}
