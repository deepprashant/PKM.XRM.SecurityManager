using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public interface ISecurityRoleManagerView
    {
        string NameSearchPhrase { get; }
        MultiSelectView UserView { get; }
        MultiSelectView TeamView { get; }
        string SelectedBusinessUnit { get; }
        int RecordCount { set; }

        event EventHandler SearchPrimaryEntity;
        event EventHandler PrimaryEntityRecordSelection;

        void SetBusinessUnitBindingSource(BindingSource businessUnits);
        void SetRolesBindingSource(BindingSource securityRoles);
        List<Guid> GetSelectedPrimaryEntityIds();
    }
}
