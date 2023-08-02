using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public interface IFieldSecurityManagerView
    {
        string NameSearchPhrase { get; }
        MultiSelectView UserView { get; }
        MultiSelectView TeamView { get; }
        int RecordCount { set; }

        event EventHandler SearchPrimaryEntity;
        event EventHandler PrimaryEntityRecordSelection;
  
        void SetFeidlSecuritiesBindingSource(BindingSource fieldSeurities);
        List<Guid> GetSelectedPrimaryEntityIds();
    }
}
