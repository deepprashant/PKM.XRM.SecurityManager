using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.View
{
    public partial class FieldSecurityManagerView : UserControl, IFieldSecurityManagerView
    {
        public string NameSearchPhrase
        {
            get
            {
                return textBoxName.Text;
            }
        }

        public int RecordCount { set => groupBoxPrimaryEntity.Text = $"Field Security Profiles: {value}"; }

        public MultiSelectView UserView { get => multiSelectViewUser; }
        public MultiSelectView TeamView { get => multiSelectViewTeam; }

        public FieldSecurityManagerView()
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

        public void SetFeidlSecuritiesBindingSource(BindingSource fieldSeurities)
        {
            dataGridPrimaryEntity.DataSource = fieldSeurities;
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

        private void dataGridPrimaryEntity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
    }
}
