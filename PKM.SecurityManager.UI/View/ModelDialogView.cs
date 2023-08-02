using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public partial class ModelDialogView : Form
    {
        public string ShowMessage
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }      

        public ModelDialogView()
        {
            InitializeComponent();
        }

        public event EventHandler NavigationEvent;

        public void CloseDialog()
        {
            this.Close();
        }
    }
}
