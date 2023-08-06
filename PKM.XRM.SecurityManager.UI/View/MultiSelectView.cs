using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.View
{
    public partial class MultiSelectView : UserControl, IMultiSelectView
    {
        private string multiSelectName;
        private string emptyGridMessage;
        private string selectedBU;
        public string MultiSelectName
        {
            get
            {
                return multiSelectName;
            }
            set
            {
                multiSelectName = value;
                groupBoxMultiselect.Text = value;
                groupBoxAssigned.Text = $"Assigned {value}:";
                groupBoxAvailable.Text = $"Available {value}:";
            }
        }
        public int AssignedCount { set => groupBoxAssigned.Text = $"Assigned {MultiSelectName}: {value}"; }
        public int AvailableCount { set => groupBoxAvailable.Text = $"Available {MultiSelectName}: {value}"; }
        public string EmptyGridMessage { set => emptyGridMessage = value; }
        public string SelectedBU { get => selectedBU; set => selectedBU = value; }

        public MultiSelectView()
        {
            InitializeComponent();
            dataGridViewAssigned.AutoGenerateColumns = false;
            dataGridViewAvailable.AutoGenerateColumns = false;
            AssociateAndRaisViewEvent();
            toolTipAssignAll.SetToolTip(buttonAssignAll, "Assign all available records.");
            toolTipAssignSelected.SetToolTip(buttonAssignSelected, "Assign selected available records.");
            toolTipRemoveAll.SetToolTip(buttonRemoveAll, "Remove all assigned records.");
            toolTipRemoveSelected.SetToolTip(buttonRemoveSelected, "Remove selected assigned records.");
        }

        private void AssociateAndRaisViewEvent()
        {
            buttonAssignSelected.Click += delegate { AssignSelected?.Invoke(this, EventArgs.Empty); };
            buttonAssignAll.Click += delegate { AssignAll?.Invoke(this, EventArgs.Empty); };
            buttonRemoveSelected.Click += delegate { RemoveSelected?.Invoke(this, EventArgs.Empty); };
            buttonRemoveAll.Click += delegate { RemoveAll?.Invoke(this, EventArgs.Empty); };
        }

        private void dataGridViewAssignedRoles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAssigned.ClearSelection();
        }

        private void dataGridViewAvailableRoles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAvailable.ClearSelection();
        }

        public event EventHandler AssignSelected;
        public event EventHandler AssignAll;
        public event EventHandler RemoveSelected;
        public event EventHandler RemoveAll;

        public void SetAssignedBindingSource(BindingSource assigned)
        {
            dataGridViewAssigned.DataSource = assigned;
            dataGridViewAssigned.ClearSelection();
        }

        public void SetAvailableBindingSource(BindingSource available)
        {
            dataGridViewAvailable.DataSource = available;
            dataGridViewAvailable.ClearSelection();
        }

        public void HighlightCommonAssigned(List<Guid> ids)
        {
            foreach (DataGridViewRow row in dataGridViewAssigned.Rows)
            {
                if (ids.Contains((Guid)row.Cells[1].Value))
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Font = new Font(dataGridViewAssigned.Font, FontStyle.Bold);
                    row.DefaultCellStyle = style;
                }
            }
        }

        public List<Guid> GetSelectedAssigned()
        {
            List<Guid> ids = new List<Guid>();
            foreach (DataGridViewRow row in this.dataGridViewAssigned.SelectedRows)
            {
                var data = (Guid)row.Cells[1].Value;
                ids.Add(data);
            }
            return ids;
        }

        public List<Guid> GetSelectedAvailable()
        {
            List<Guid> ids = new List<Guid>();
            foreach (DataGridViewRow row in this.dataGridViewAvailable.SelectedRows)
            {
                var data = (Guid)row.Cells[1].Value;
                ids.Add(data);
            }
            return ids;
        }

        public void HideBusinessUniteColumn()
        {
            dataGridViewAvailable.Columns["availableBusinessUnit"].Visible = false;
            dataGridViewAssigned.Columns["assignedBusinessUnit"].Visible = false;
        }

        private void dataGridViewAssigned_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewAssigned.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, emptyGridMessage,
                    dataGridViewAssigned.Font, dataGridViewAssigned.ClientRectangle,
                    dataGridViewAssigned.ForeColor, dataGridViewAssigned.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void dataGridViewAvailable_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewAvailable.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, emptyGridMessage,
                    dataGridViewAvailable.Font, dataGridViewAvailable.ClientRectangle,
                    dataGridViewAvailable.ForeColor, dataGridViewAvailable.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
