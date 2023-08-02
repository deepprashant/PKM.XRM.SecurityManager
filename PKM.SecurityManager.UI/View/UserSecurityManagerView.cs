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
    public partial class UserSecurityManagerView : UserControl, IUserSecurityManagerView
    {
        public string UserNameSearchPhrase
        {
            get
            {
                return textBoxUserName.Text;
            }
        }

        public string SelectedUserEntityViewFetchXML
        {
            get
            {
                return comboBoxUserViews.SelectedValue.ToString();
            }
        }

        public List<object> SelectedUsers
        {
            get
            {
                //TODO
                List<object> selectedUsers = new List<object>();
                foreach (DataGridViewRow row in this.dataGridUsers.SelectedRows)
                {
                    selectedUsers.Add(row.DataBoundItem);
                }

                return selectedUsers;
            }
        }

        public int UserCount { set => groupBoxUsers.Text = $"Users: {value}"; }
        public int DirectAndTeamRoleCount { set => groupBoxDirectAndTeamRoles.Text = $"All Assigned Roles (Direct and Team): {value}"; }
        public int DirectAndTeamFSPCount { set => groupBoxDirectAndTeamFSPs.Text = $"All Assigned Field Security Profiles (Direct and Team): {value}"; }

        public MultiSelectView SecurityRoleView { get => multiSelectViewRole; }
        public MultiSelectView TeamView { get => multiSelectViewTeam; }
        public MultiSelectView FieldSecurityProfileView { get => multiSelectViewFSP; }

        public UserSecurityManagerView()
        {
            InitializeComponent();
            dataGridUsers.AutoGenerateColumns = false;
            splitContainerUserSecurityManager.SplitterDistance = 200;
            dataGridViewDirectAndTeamRoles.AutoGenerateColumns = false;
            dataGridViewDirectAndTeamFSPs.AutoGenerateColumns = false;
            AssociateAndRaisViewEvent();
        }

        private void AssociateAndRaisViewEvent()
        {
            buttonSearchUser.Click += delegate { SearchUser?.Invoke(this, EventArgs.Empty); };
            dataGridUsers.SelectionChanged += delegate { UserSelection?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler SearchUser;
        public event EventHandler UserSelection;

        public void SetUsersBindingSource(BindingSource users)
        {
            dataGridUsers.DataSource = users;
        }

        public void SetUserEntityViewBindingSource(BindingSource userEntityViews)
        {
            comboBoxUserViews.DataSource = userEntityViews.DataSource;
            comboBoxUserViews.DisplayMember = "Name";
            comboBoxUserViews.ValueMember = "FetchXML";
        }

        public List<Guid> GetSelectedUseresId()
        {
            List<Guid> selectedUsers = new List<Guid>();
            foreach (DataGridViewRow row in this.dataGridUsers.SelectedRows)
            {
                var data = (Guid)row.Cells[1].Value;
                selectedUsers.Add(data);
            }

            return selectedUsers;
        }

        public void SetUserDirectAndTeamRolesBindingSource(BindingSource allRoles)
        {
            dataGridViewDirectAndTeamRoles.DataSource = allRoles;
        }

        public void SetUserDirectAndTeamFSPsBindingSource(BindingSource allFsps)
        {
            dataGridViewDirectAndTeamFSPs.DataSource = allFsps;
        }

        private void dataGridUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridUsers.ClearSelection();
        }

        private void dataGridUsers_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridUsers.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridUsers.Font, dataGridUsers.ClientRectangle,
                    dataGridUsers.ForeColor, dataGridUsers.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void dataGridViewDirectAndTeamRoles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewDirectAndTeamRoles.ClearSelection();
        }

        private void dataGridViewDirectAndTeamFSPs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewDirectAndTeamFSPs.ClearSelection();
        }

        private void dataGridViewDirectAndTeamRoles_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewDirectAndTeamRoles.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found (This features works if only one user is selected)",
                    dataGridViewDirectAndTeamRoles.Font, dataGridViewDirectAndTeamRoles.ClientRectangle,
                    dataGridViewDirectAndTeamRoles.ForeColor, dataGridViewDirectAndTeamRoles.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void dataGridViewDirectAndTeamFSPs_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewDirectAndTeamFSPs.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found (This features works if only one user is selected)",
                    dataGridViewDirectAndTeamFSPs.Font, dataGridViewDirectAndTeamFSPs.ClientRectangle,
                    dataGridViewDirectAndTeamFSPs.ForeColor, dataGridViewDirectAndTeamFSPs.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
