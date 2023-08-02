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
    public partial class TeamSecurityManagerView : UserControl, ITeamSecurityManagerView
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
                foreach (DataGridViewRow row in this.dataGridTeams.SelectedRows)
                {
                    selectedUsers.Add(row.DataBoundItem);
                }

                return selectedUsers;
            }
        }

        public int UserCount { set => groupBoxPrimaryEntity.Text = $"Users: {value}"; }

        public MultiSelectView SecurityRoleView { get => multiSelectViewRole; }
        public MultiSelectView UserView { get => multiSelectViewTeam; }
        public MultiSelectView FieldSecurityProfileView { get => multiSelectViewFSP; }

        public TeamSecurityManagerView()
        {
            InitializeComponent();
            dataGridTeams.AutoGenerateColumns = false;
            splitContainerUserSecurityManager.SplitterDistance = 200;
            AssociateAndRaisViewEvent();
        }

        private void AssociateAndRaisViewEvent()
        {
            buttonSearch.Click += delegate { SearchUser?.Invoke(this, EventArgs.Empty); };
            dataGridTeams.SelectionChanged += delegate { UserSelection?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler SearchUser;
        public event EventHandler UserSelection;

        public void SetUsersBindingSource(BindingSource users)
        {
            dataGridTeams.DataSource = users;
        }

        public void SetTeamEntityViewBindingSource(BindingSource userEntityViews)
        {
            comboBoxUserViews.DataSource = userEntityViews.DataSource;
            comboBoxUserViews.DisplayMember = "Name";
            comboBoxUserViews.ValueMember = "FetchXML";
        }

        public List<Guid> GetSelectedTeamsId()
        {
            List<Guid> selectedUsers = new List<Guid>();
            foreach (DataGridViewRow row in this.dataGridTeams.SelectedRows)
            {
                var data = (Guid)row.Cells[1].Value;
                selectedUsers.Add(data);
            }

            return selectedUsers;
        }

        private void dataGridTeams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridTeams.ClearSelection();
        }

        private void dataGridTeams_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridTeams.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridTeams.Font, dataGridTeams.ClientRectangle,
                    dataGridTeams.ForeColor, dataGridTeams.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
