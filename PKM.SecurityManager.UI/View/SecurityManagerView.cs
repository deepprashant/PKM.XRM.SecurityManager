using PKM.SecurityManager.Common;
using PKM.SecurityManager.UI.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace PKM.SecurityManager.UI.View
{
    public partial class SecurityManagerView : UserControl, ISecurityManagerView
    {
        bool leftPanelExpanded = true;
        public SecurityManagerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
        }

        private void AssociateAndRaiseViewEvent()
        {
            buttonUSM.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.UserSecurityManagerView }); };
            buttonTSM.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.TeamSecurityManagerView }); };
            buttonFSPM.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.FieldSecurityProfileManagerView }); };
            buttonSRM.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.SecurityRoleManagerView }); };
            buttonSecurityReport.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.SecurityReportsView }); };
            pictureBoxClose.Click += delegate { NavigationEvent?.Invoke(this, new SecurityManagerEventArgs() { DisaplayView = Constants.CloseTool }); };
        }

        public event EventHandler NavigationEvent;

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //sidebarTimer.Start();
            if (leftPanelExpanded)
            {
                leftPanel.Width = 40;
                leftPanelExpanded = false;
            }
            else
            {
                leftPanel.Width = 200;
                leftPanelExpanded = true;
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (leftPanelExpanded)
            {
                leftPanel.Width -= 10;
                if (leftPanel.Width == leftPanel.MinimumSize.Width)
                {
                    leftPanelExpanded = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                leftPanel.Width += 10;
                if (leftPanel.Width == leftPanel.MaximumSize.Width)
                {
                    leftPanelExpanded = true;
                    sidebarTimer.Stop();
                }
            }
        }

        public void ClearAndDisplayControlInBodyPanel(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            this.bodyPanel.Controls.Clear();
            this.bodyPanel.Controls.Add(control);
        }
    }
}
