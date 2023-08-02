using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public interface ISecurityManagerView
    {
        event EventHandler NavigationEvent;
        void ClearAndDisplayControlInBodyPanel(UserControl control);
    }
}
