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
    public partial class SecurityRoleManagerView : UserControl, ISecurityRoleManagerView
    {
        public string NameSearchPhrase
        {
            get
            {
                return textBoxName.Text;
            }
        }

        public int RecordCount { set => groupBoxPrimaryEntity.Text = $"Security Roles: {value}"; }

        public MultiSelectView UserView { get => multiSelectViewUser; }
        public MultiSelectView TeamView { get => multiSelectViewTeam; }

        public string SelectedBusinessUnit { get => comboBoxBusinessUnit.SelectedValue.ToString(); }

        public SecurityRoleManagerView()
        {
            InitializeComponent();
            dataGridPrimaryEntity.AutoGenerateColumns = false;
            splitContainerSecurityManager.SplitterDistance = 200;
            AssociateAndRaisViewEvent();
        }

        private void AssociateAndRaisViewEvent()
        {
            buttonSearch.Click += delegate { SearchPrimaryEntity?.Invoke(this, EventArgs.Empty); };
            dataGridPrimaryEntity.SelectionChanged += delegate { PrimaryEntityRecordSelection?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler SearchPrimaryEntity;
        public event EventHandler PrimaryEntityRecordSelection;

        public void SetBusinessUnitBindingSource(BindingSource businessUnits)
        {
            comboBoxBusinessUnit.DataSource = businessUnits.DataSource;
            comboBoxBusinessUnit.DisplayMember = "Name";
            comboBoxBusinessUnit.ValueMember = "Id";
        }
        public void SetRolesBindingSource(BindingSource securityRoles)
        {
            dataGridPrimaryEntity.DataSource = securityRoles;
        }

        public List<Guid> GetSelectedPrimaryEntityIds()
        {
            List<Guid> selectedPrimaryEntityIds = new List<Guid>();
            foreach (DataGridViewRow row in this.dataGridPrimaryEntity.SelectedRows)
            {
                var data = (Guid)row.Cells[1].Value;
                selectedPrimaryEntityIds.Add(data);
            }

            return selectedPrimaryEntityIds;
        }

        private void dataGridPrimaryEntitieyRecords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridPrimaryEntity.ClearSelection();
        }

        private void dataGridPrimaryEntity_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridPrimaryEntity.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    dataGridPrimaryEntity.Font, dataGridPrimaryEntity.ClientRectangle,
                    dataGridPrimaryEntity.ForeColor, dataGridPrimaryEntity.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void dataGridPrimaryEntity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridPrimaryEntity.ClearSelection();
        }
    }
}
