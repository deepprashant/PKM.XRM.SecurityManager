namespace PKM.SecurityManager.UI.View
{
    partial class MultiSelectView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMultiselect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAssigned = new System.Windows.Forms.GroupBox();
            this.dataGridViewAssigned = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.assignedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAvailable = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailable = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.availableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelRoleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAssignAll = new System.Windows.Forms.Button();
            this.buttonAssignSelected = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.toolTipAssignAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAssignSelected = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRemoveAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRemoveSelected = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMultiselect.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigned)).BeginInit();
            this.groupBoxAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).BeginInit();
            this.flowLayoutPanelRoleButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMultiselect
            // 
            this.groupBoxMultiselect.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxMultiselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMultiselect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMultiselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMultiselect.Name = "groupBoxMultiselect";
            this.groupBoxMultiselect.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMultiselect.Size = new System.Drawing.Size(811, 951);
            this.groupBoxMultiselect.TabIndex = 0;
            this.groupBoxMultiselect.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBoxAssigned, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBoxAvailable, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanelRoleButtons, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(803, 928);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupBoxAssigned
            // 
            this.groupBoxAssigned.Controls.Add(this.dataGridViewAssigned);
            this.groupBoxAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAssigned.Location = new System.Drawing.Point(4, 4);
            this.groupBoxAssigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAssigned.Name = "groupBoxAssigned";
            this.groupBoxAssigned.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.SetRowSpan(this.groupBoxAssigned, 2);
            this.groupBoxAssigned.Size = new System.Drawing.Size(373, 920);
            this.groupBoxAssigned.TabIndex = 3;
            this.groupBoxAssigned.TabStop = false;
            this.groupBoxAssigned.Text = "Assigned:";
            // 
            // dataGridViewAssigned
            // 
            this.dataGridViewAssigned.AllowUserToAddRows = false;
            this.dataGridViewAssigned.AllowUserToDeleteRows = false;
            this.dataGridViewAssigned.AllowUserToOrderColumns = true;
            this.dataGridViewAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.assignedId,
            this.assignedName,
            this.assignedBusinessUnit});
            this.dataGridViewAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssigned.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewAssigned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAssigned.Name = "dataGridViewAssigned";
            this.dataGridViewAssigned.ReadOnly = true;
            this.dataGridViewAssigned.RowHeadersVisible = false;
            this.dataGridViewAssigned.RowHeadersWidth = 51;
            this.dataGridViewAssigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAssigned.Size = new System.Drawing.Size(365, 897);
            this.dataGridViewAssigned.TabIndex = 2;
            this.dataGridViewAssigned.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewAssignedRoles_DataBindingComplete);
            this.dataGridViewAssigned.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewAssigned_Paint);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 45;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            this.dataGridViewCheckBoxColumn2.Width = 45;
            // 
            // assignedId
            // 
            this.assignedId.DataPropertyName = "Id";
            this.assignedId.HeaderText = "Id";
            this.assignedId.MinimumWidth = 6;
            this.assignedId.Name = "assignedId";
            this.assignedId.ReadOnly = true;
            this.assignedId.Visible = false;
            this.assignedId.Width = 125;
            // 
            // assignedName
            // 
            this.assignedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignedName.DataPropertyName = "Name";
            this.assignedName.HeaderText = "Name";
            this.assignedName.MinimumWidth = 6;
            this.assignedName.Name = "assignedName";
            this.assignedName.ReadOnly = true;
            // 
            // assignedBusinessUnit
            // 
            this.assignedBusinessUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignedBusinessUnit.DataPropertyName = "BusinessUnitName";
            this.assignedBusinessUnit.HeaderText = "Business Unit";
            this.assignedBusinessUnit.MinimumWidth = 6;
            this.assignedBusinessUnit.Name = "assignedBusinessUnit";
            this.assignedBusinessUnit.ReadOnly = true;
            // 
            // groupBoxAvailable
            // 
            this.groupBoxAvailable.Controls.Add(this.dataGridViewAvailable);
            this.groupBoxAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAvailable.Location = new System.Drawing.Point(426, 4);
            this.groupBoxAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAvailable.Name = "groupBoxAvailable";
            this.groupBoxAvailable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.SetRowSpan(this.groupBoxAvailable, 2);
            this.groupBoxAvailable.Size = new System.Drawing.Size(373, 920);
            this.groupBoxAvailable.TabIndex = 4;
            this.groupBoxAvailable.TabStop = false;
            this.groupBoxAvailable.Text = "Available:";
            // 
            // dataGridViewAvailable
            // 
            this.dataGridViewAvailable.AllowUserToAddRows = false;
            this.dataGridViewAvailable.AllowUserToDeleteRows = false;
            this.dataGridViewAvailable.AllowUserToOrderColumns = true;
            this.dataGridViewAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.availableId,
            this.availableName,
            this.availableBusinessUnit});
            this.dataGridViewAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAvailable.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAvailable.Name = "dataGridViewAvailable";
            this.dataGridViewAvailable.ReadOnly = true;
            this.dataGridViewAvailable.RowHeadersVisible = false;
            this.dataGridViewAvailable.RowHeadersWidth = 51;
            this.dataGridViewAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailable.Size = new System.Drawing.Size(365, 897);
            this.dataGridViewAvailable.TabIndex = 1;
            this.dataGridViewAvailable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewAvailableRoles_DataBindingComplete);
            this.dataGridViewAvailable.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewAvailable_Paint);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 45;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 45;
            // 
            // availableId
            // 
            this.availableId.DataPropertyName = "Id";
            this.availableId.HeaderText = "Id";
            this.availableId.MinimumWidth = 6;
            this.availableId.Name = "availableId";
            this.availableId.ReadOnly = true;
            this.availableId.Visible = false;
            this.availableId.Width = 125;
            // 
            // availableName
            // 
            this.availableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availableName.DataPropertyName = "Name";
            this.availableName.HeaderText = "Name";
            this.availableName.MinimumWidth = 6;
            this.availableName.Name = "availableName";
            this.availableName.ReadOnly = true;
            // 
            // availableBusinessUnit
            // 
            this.availableBusinessUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availableBusinessUnit.DataPropertyName = "BusinessUnitName";
            this.availableBusinessUnit.HeaderText = "Business Unit";
            this.availableBusinessUnit.MinimumWidth = 6;
            this.availableBusinessUnit.Name = "availableBusinessUnit";
            this.availableBusinessUnit.ReadOnly = true;
            // 
            // flowLayoutPanelRoleButtons
            // 
            this.flowLayoutPanelRoleButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelRoleButtons.Controls.Add(this.buttonAssignAll);
            this.flowLayoutPanelRoleButtons.Controls.Add(this.buttonAssignSelected);
            this.flowLayoutPanelRoleButtons.Controls.Add(this.buttonRemoveSelected);
            this.flowLayoutPanelRoleButtons.Controls.Add(this.buttonRemoveAll);
            this.flowLayoutPanelRoleButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRoleButtons.Location = new System.Drawing.Point(381, 285);
            this.flowLayoutPanelRoleButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelRoleButtons.Name = "flowLayoutPanelRoleButtons";
            this.tableLayoutPanel4.SetRowSpan(this.flowLayoutPanelRoleButtons, 2);
            this.flowLayoutPanelRoleButtons.Size = new System.Drawing.Size(41, 357);
            this.flowLayoutPanelRoleButtons.TabIndex = 7;
            // 
            // buttonAssignAll
            // 
            this.buttonAssignAll.FlatAppearance.BorderSize = 2;
            this.buttonAssignAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssignAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignAll.Location = new System.Drawing.Point(1, 1);
            this.buttonAssignAll.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAssignAll.Name = "buttonAssignAll";
            this.buttonAssignAll.Size = new System.Drawing.Size(39, 86);
            this.buttonAssignAll.TabIndex = 6;
            this.buttonAssignAll.Text = "<<";
            this.buttonAssignAll.UseVisualStyleBackColor = true;
            // 
            // buttonAssignSelected
            // 
            this.buttonAssignSelected.FlatAppearance.BorderSize = 2;
            this.buttonAssignSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssignSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssignSelected.Location = new System.Drawing.Point(1, 89);
            this.buttonAssignSelected.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAssignSelected.Name = "buttonAssignSelected";
            this.buttonAssignSelected.Size = new System.Drawing.Size(39, 86);
            this.buttonAssignSelected.TabIndex = 5;
            this.buttonAssignSelected.Text = "<";
            this.buttonAssignSelected.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.FlatAppearance.BorderSize = 2;
            this.buttonRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSelected.Location = new System.Drawing.Point(1, 177);
            this.buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(39, 86);
            this.buttonRemoveSelected.TabIndex = 5;
            this.buttonRemoveSelected.Text = ">";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAll.Location = new System.Drawing.Point(1, 265);
            this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(39, 86);
            this.buttonRemoveAll.TabIndex = 6;
            this.buttonRemoveAll.Text = ">>";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            // 
            // MultiSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMultiselect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MultiSelectView";
            this.Size = new System.Drawing.Size(811, 951);
            this.groupBoxMultiselect.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBoxAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigned)).EndInit();
            this.groupBoxAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).EndInit();
            this.flowLayoutPanelRoleButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMultiselect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridViewAssigned;
        private System.Windows.Forms.DataGridView dataGridViewAvailable;
        private System.Windows.Forms.GroupBox groupBoxAssigned;
        private System.Windows.Forms.GroupBox groupBoxAvailable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRoleButtons;
        private System.Windows.Forms.Button buttonAssignSelected;
        private System.Windows.Forms.Button buttonAssignAll;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.ToolTip toolTipAssignAll;
        private System.Windows.Forms.ToolTip toolTipAssignSelected;
        private System.Windows.Forms.ToolTip toolTipRemoveAll;
        private System.Windows.Forms.ToolTip toolTipRemoveSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedBusinessUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableBusinessUnit;
    }
}
