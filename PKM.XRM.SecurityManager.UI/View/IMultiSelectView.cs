using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.View
{
    public interface IMultiSelectView
    {
        string MultiSelectName { get; set; }
        int AssignedCount { set; }
        int AvailableCount { set; }
        string EmptyGridMessage { set; }

        string SelectedBU { get; set; }

        event EventHandler AssignSelected;
        event EventHandler AssignAll;
        event EventHandler RemoveSelected;
        event EventHandler RemoveAll;

        void SetAssignedBindingSource(BindingSource assigned);

        void SetAvailableBindingSource(BindingSource available);

        void HighlightCommonAssigned(List<Guid> ids);

        List<Guid> GetSelectedAssigned();

        List<Guid> GetSelectedAvailable();

        void HideBusinessUniteColumn();
    }
}
