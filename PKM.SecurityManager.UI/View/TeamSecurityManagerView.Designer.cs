namespace PKM.SecurityManager.UI.View
{
    partial class TeamSecurityManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSecurityManagerView));
            this.tabPageRolesAndTeams = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerUserSecurityManager = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxUserViews = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPrimaryEntity = new System.Windows.Forms.GroupBox();
            this.dataGridTeams = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlUSM = new System.Windows.Forms.TabControl();
            this.tabPageFSP = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.multiSelectViewRole = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.multiSelectViewTeam = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.multiSelectViewFSP = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.tabPageRolesAndTeams.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserSecurityManager)).BeginInit();
            this.splitContainerUserSecurityManager.Panel1.SuspendLayout();
            this.splitContainerUserSecurityManager.Panel2.SuspendLayout();
            this.splitContainerUserSecurityManager.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxPrimaryEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeams)).BeginInit();
            this.tabControlUSM.SuspendLayout();
            this.tabPageFSP.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageRolesAndTeams
            // 
            this.tabPageRolesAndTeams.Controls.Add(this.tableLayoutPanel3);
            this.tabPageRolesAndTeams.ImageIndex = 0;
            this.tabPageRolesAndTeams.Location = new System.Drawing.Point(4, 23);
            this.tabPageRolesAndTeams.Name = "tabPageRolesAndTeams";
            this.tabPageRolesAndTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRolesAndTeams.Size = new System.Drawing.Size(1014, 746);
            this.tabPageRolesAndTeams.TabIndex = 0;
            this.tabPageRolesAndTeams.Text = "Roles & Teams";
            this.tabPageRolesAndTeams.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.multiSelectViewRole, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.multiSelectViewTeam, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 740);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // splitContainerUserSecurityManager
            // 
            this.splitContainerUserSecurityManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUserSecurityManager.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUserSecurityManager.Name = "splitContainerUserSecurityManager";
            // 
            // splitContainerUserSecurityManager.Panel1
            // 
            this.splitContainerUserSecurityManager.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerUserSecurityManager.Panel2
            // 
            this.splitContainerUserSecurityManager.Panel2.Controls.Add(this.tabControlUSM);
            this.splitContainerUserSecurityManager.Size = new System.Drawing.Size(1363, 773);
            this.splitContainerUserSecurityManager.SplitterDistance = 337;
            this.splitContainerUserSecurityManager.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPrimaryEntity, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 773);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(331, 94);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Team Filter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxUserViews, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUserName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearch, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 75);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBoxUserViews
            // 
            this.comboBoxUserViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUserViews.FormattingEnabled = true;
            this.comboBoxUserViews.Location = new System.Drawing.Point(133, 3);
            this.comboBoxUserViews.Name = "comboBoxUserViews";
            this.comboBoxUserViews.Size = new System.Drawing.Size(189, 21);
            this.comboBoxUserViews.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserName.Location = new System.Drawing.Point(133, 28);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(189, 20);
            this.textBoxUserName.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(133, 53);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(189, 19);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search And Load Teams";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Team\'s View:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team Name Contains:";
            // 
            // groupBoxPrimaryEntity
            // 
            this.groupBoxPrimaryEntity.Controls.Add(this.dataGridTeams);
            this.groupBoxPrimaryEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPrimaryEntity.Location = new System.Drawing.Point(3, 103);
            this.groupBoxPrimaryEntity.Name = "groupBoxPrimaryEntity";
            this.groupBoxPrimaryEntity.Size = new System.Drawing.Size(331, 667);
            this.groupBoxPrimaryEntity.TabIndex = 1;
            this.groupBoxPrimaryEntity.TabStop = false;
            this.groupBoxPrimaryEntity.Text = "Teams:";
            // 
            // dataGridTeams
            // 
            this.dataGridTeams.AllowUserToAddRows = false;
            this.dataGridTeams.AllowUserToDeleteRows = false;
            this.dataGridTeams.AllowUserToOrderColumns = true;
            this.dataGridTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id,
            this.UserName,
            this.BusinessUnit});
            this.dataGridTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTeams.Location = new System.Drawing.Point(3, 16);
            this.dataGridTeams.Name = "dataGridTeams";
            this.dataGridTeams.ReadOnly = true;
            this.dataGridTeams.RowHeadersVisible = false;
            this.dataGridTeams.RowHeadersWidth = 51;
            this.dataGridTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeams.Size = new System.Drawing.Size(325, 648);
            this.dataGridTeams.TabIndex = 0;
            this.dataGridTeams.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridTeams_DataBindingComplete);
            this.dataGridTeams.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridTeams_Paint);
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
            // 
            // tabControlUSM
            // 
            this.tabControlUSM.Controls.Add(this.tabPageRolesAndTeams);
            this.tabControlUSM.Controls.Add(this.tabPageFSP);
            this.tabControlUSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUSM.ImageList = this.imageList1;
            this.tabControlUSM.Location = new System.Drawing.Point(0, 0);
            this.tabControlUSM.Multiline = true;
            this.tabControlUSM.Name = "tabControlUSM";
            this.tabControlUSM.SelectedIndex = 0;
            this.tabControlUSM.Size = new System.Drawing.Size(1022, 773);
            this.tabControlUSM.TabIndex = 0;
            // 
            // tabPageFSP
            // 
            this.tabPageFSP.Controls.Add(this.tableLayoutPanel4);
            this.tabPageFSP.ImageIndex = 1;
            this.tabPageFSP.Location = new System.Drawing.Point(4, 23);
            this.tabPageFSP.Name = "tabPageFSP";
            this.tabPageFSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFSP.Size = new System.Drawing.Size(1014, 746);
            this.tabPageFSP.TabIndex = 2;
            this.tabPageFSP.Text = "Field Security Profile";
            this.tabPageFSP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.multiSelectViewFSP, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1008, 740);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-user-25.png");
            this.imageList1.Images.SetKeyName(1, "icons8-team-25.png");
            this.imageList1.Images.SetKeyName(2, "icons8-authorization-25.png");
            this.imageList1.Images.SetKeyName(3, "icons8-show-password-25.png");
            // 
            // multiSelectViewRole
            // 
            this.multiSelectViewRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewRole.Location = new System.Drawing.Point(3, 3);
            this.multiSelectViewRole.MultiSelectName = null;
            this.multiSelectViewRole.Name = "multiSelectViewRole";
            this.multiSelectViewRole.Size = new System.Drawing.Size(498, 734);
            this.multiSelectViewRole.TabIndex = 1;
            // 
            // multiSelectViewTeam
            // 
            this.multiSelectViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewTeam.Location = new System.Drawing.Point(507, 3);
            this.multiSelectViewTeam.MultiSelectName = null;
            this.multiSelectViewTeam.Name = "multiSelectViewTeam";
            this.multiSelectViewTeam.Size = new System.Drawing.Size(498, 734);
            this.multiSelectViewTeam.TabIndex = 2;
            // 
            // multiSelectViewFSP
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.multiSelectViewFSP, 2);
            this.multiSelectViewFSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewFSP.Location = new System.Drawing.Point(3, 3);
            this.multiSelectViewFSP.MultiSelectName = null;
            this.multiSelectViewFSP.Name = "multiSelectViewFSP";
            this.multiSelectViewFSP.Size = new System.Drawing.Size(1002, 734);
            this.multiSelectViewFSP.TabIndex = 1;
            // 
            // TeamSecurityManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerUserSecurityManager);
            this.Name = "TeamSecurityManagerView";
            this.Size = new System.Drawing.Size(1363, 773);
            this.tabPageRolesAndTeams.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainerUserSecurityManager.Panel1.ResumeLayout(false);
            this.splitContainerUserSecurityManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserSecurityManager)).EndInit();
            this.splitContainerUserSecurityManager.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxPrimaryEntity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeams)).EndInit();
            this.tabControlUSM.ResumeLayout(false);
            this.tabPageFSP.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageRolesAndTeams;
        private System.Windows.Forms.SplitContainer splitContainerUserSecurityManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxUserViews;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPrimaryEntity;
        private System.Windows.Forms.DataGridView dataGridTeams;
        private System.Windows.Forms.TabControl tabControlUSM;
        private System.Windows.Forms.TabPage tabPageFSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessUnit;
        private MultiSelectView multiSelectViewRole;
        private MultiSelectView multiSelectViewTeam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MultiSelectView multiSelectViewFSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}
