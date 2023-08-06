using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.View
{
    public interface ITeamSecurityManagerView
    {
        string UserNameSearchPhrase { get; }
        MultiSelectView SecurityRoleView { get; }
        MultiSelectView UserView { get; }
        MultiSelectView FieldSecurityProfileView { get; }
        string SelectedUserEntityViewFetchXML { get; }
        int UserCount { set; }

        event EventHandler SearchPrimaryEntity;

        event EventHandler PrimaryEntityRecordSelection;

        void SetTeamEntityViewBindingSource(BindingSource userEntityViews);
        void SetUsersBindingSource(BindingSource users);
        void Show();
        List<Guid> GetSelectedTeamsId();
    }
}
