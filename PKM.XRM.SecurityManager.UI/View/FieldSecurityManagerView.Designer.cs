namespace PKM.XRM.SecurityManager.UI.View
{
    partial class FieldSecurityManagerView
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.multiSelectViewUser = new PKM.XRM.SecurityManager.UI.View.MultiSelectView();
            this.multiSelectViewTeam = new PKM.XRM.SecurityManager.UI.View.MultiSelectView();
            this.splitContainerSecurityManager = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPrimaryEntity = new System.Windows.Forms.GroupBox();
            this.dataGridPrimaryEntity = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecurityManager)).BeginInit();
            this.splitContainerSecurityManager.Panel1.SuspendLayout();
            this.splitContainerSecurityManager.Panel2.SuspendLayout();
            this.splitContainerSecurityManager.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxPrimaryEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrimaryEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.multiSelectViewUser, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.multiSelectViewTeam, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1363, 951);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // multiSelectViewUser
            // 
            this.multiSelectViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewUser.Location = new System.Drawing.Point(5, 5);
            this.multiSelectViewUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.multiSelectViewUser.MultiSelectName = null;
            this.multiSelectViewUser.Name = "multiSelectViewUser";
            this.multiSelectViewUser.Size = new System.Drawing.Size(671, 941);
            this.multiSelectViewUser.TabIndex = 1;
            // 
            // multiSelectViewTeam
            // 
            this.multiSelectViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewTeam.Location = new System.Drawing.Point(686, 5);
            this.multiSelectViewTeam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.multiSelectViewTeam.MultiSelectName = null;
            this.multiSelectViewTeam.Name = "multiSelectViewTeam";
            this.multiSelectViewTeam.Size = new System.Drawing.Size(672, 941);
            this.multiSelectViewTeam.TabIndex = 2;
            // 
            // splitContainerSecurityManager
            // 
            this.splitContainerSecurityManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSecurityManager.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSecurityManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerSecurityManager.Name = "splitContainerSecurityManager";
            // 
            // splitContainerSecurityManager.Panel1
            // 
            this.splitContainerSecurityManager.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerSecurityManager.Panel2
            // 
            this.splitContainerSecurityManager.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainerSecurityManager.Size = new System.Drawing.Size(1817, 951);
            this.splitContainerSecurityManager.SplitterDistance = 449;
            this.splitContainerSecurityManager.SplitterWidth = 5;
            this.splitContainerSecurityManager.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPrimaryEntity, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 951);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFilter.Size = new System.Drawing.Size(441, 115);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Field Security Profile Filter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearch, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 92);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(177, 4);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(177, 64);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(252, 24);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search And Load Profile";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profile Name Contains:";
            // 
            // groupBoxPrimaryEntity
            // 
            this.groupBoxPrimaryEntity.Controls.Add(this.dataGridPrimaryEntity);
            this.groupBoxPrimaryEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPrimaryEntity.Location = new System.Drawing.Point(4, 127);
            this.groupBoxPrimaryEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPrimaryEntity.Name = "groupBoxPrimaryEntity";
            this.groupBoxPrimaryEntity.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPrimaryEntity.Size = new System.Drawing.Size(441, 820);
            this.groupBoxPrimaryEntity.TabIndex = 1;
            this.groupBoxPrimaryEntity.TabStop = false;
            this.groupBoxPrimaryEntity.Text = "Field Security Profiles:";
            // 
            // dataGridPrimaryEntity
            // 
            this.dataGridPrimaryEntity.AllowUserToAddRows = false;
            this.dataGridPrimaryEntity.AllowUserToDeleteRows = false;
            this.dataGridPrimaryEntity.AllowUserToOrderColumns = true;
            this.dataGridPrimaryEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrimaryEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id,
            this.UserName,
            this.BusinessUnit});
            this.dataGridPrimaryEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPrimaryEntity.Location = new System.Drawing.Point(4, 19);
            this.dataGridPrimaryEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridPrimaryEntity.Name = "dataGridPrimaryEntity";
            this.dataGridPrimaryEntity.ReadOnly = true;
            this.dataGridPrimaryEntity.RowHeadersVisible = false;
            this.dataGridPrimaryEntity.RowHeadersWidth = 51;
            this.dataGridPrimaryEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrimaryEntity.Size = new System.Drawing.Size(433, 797);
            this.dataGridPrimaryEntity.TabIndex = 0;
            this.dataGridPrimaryEntity.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridPrimaryEntity_DataBindingComplete);
            this.dataGridPrimaryEntity.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridPrimaryEntity_Paint);
            // 
            // Select
            // 
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 45;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Visible = false;
            this.Select.Width = 45;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 3;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 3;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // BusinessUnit
            // 
            this.BusinessUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BusinessUnit.DataPropertyName = "BusinessUnitName";
            this.BusinessUnit.HeaderText = "Business Unit";
            this.BusinessUnit.MinimumWidth = 6;
            this.BusinessUnit.Name = "BusinessUnit";
            this.BusinessUnit.ReadOnly = true;
            this.BusinessUnit.Visible = false;
            // 
            // FieldSecurityManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerSecurityManager);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FieldSecurityManagerView";
            this.Size = new System.Drawing.Size(1817, 951);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainerSecurityManager.Panel1.ResumeLayout(false);
            this.splitContainerSecurityManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecurityManager)).EndInit();
            this.splitContainerSecurityManager.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxPrimaryEntity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrimaryEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerSecurityManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPrimaryEntity;
        private System.Windows.Forms.DataGridView dataGridPrimaryEntity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MultiSelectView multiSelectViewUser;
        private MultiSelectView multiSelectViewTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessUnit;
    }
}
