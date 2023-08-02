namespace PKM.SecurityManager.UI.View
{
    partial class UserSecurityManagerView
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
            this.tabPageRolesAndTeams = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.multiSelectViewRole = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.multiSelectViewTeam = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.splitContainerUserSecurityManager = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxUserViews = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.labelUsersView = new System.Windows.Forms.Label();
            this.labelUsersName = new System.Windows.Forms.Label();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlUSM = new System.Windows.Forms.TabControl();
            this.tabPageFSPsAndOthers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.multiSelectViewFSP = new PKM.SecurityManager.UI.View.MultiSelectView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDirectAndTeamFSPs = new System.Windows.Forms.GroupBox();
            this.dataGridViewDirectAndTeamFSPs = new System.Windows.Forms.DataGridView();
            this.FSPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSPTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSPTeamBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDirectAndTeamRoles = new System.Windows.Forms.GroupBox();
            this.dataGridViewDirectAndTeamRoles = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamBusinessUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPageRolesAndTeams.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserSecurityManager)).BeginInit();
            this.splitContainerUserSecurityManager.Panel1.SuspendLayout();
            this.splitContainerUserSecurityManager.Panel2.SuspendLayout();
            this.splitContainerUserSecurityManager.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.tabControlUSM.SuspendLayout();
            this.tabPageFSPsAndOthers.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxDirectAndTeamFSPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectAndTeamFSPs)).BeginInit();
            this.groupBoxDirectAndTeamRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectAndTeamRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageRolesAndTeams
            // 
            this.tabPageRolesAndTeams.Controls.Add(this.tableLayoutPanel3);
            this.tabPageRolesAndTeams.Location = new System.Drawing.Point(4, 22);
            this.tabPageRolesAndTeams.Name = "tabPageRolesAndTeams";
            this.tabPageRolesAndTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRolesAndTeams.Size = new System.Drawing.Size(1014, 747);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 741);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // multiSelectViewRole
            // 
            this.multiSelectViewRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewRole.Location = new System.Drawing.Point(3, 3);
            this.multiSelectViewRole.MultiSelectName = null;
            this.multiSelectViewRole.Name = "multiSelectViewRole";
            this.multiSelectViewRole.Size = new System.Drawing.Size(498, 735);
            this.multiSelectViewRole.TabIndex = 1;
            // 
            // multiSelectViewTeam
            // 
            this.multiSelectViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewTeam.Location = new System.Drawing.Point(507, 3);
            this.multiSelectViewTeam.MultiSelectName = null;
            this.multiSelectViewTeam.Name = "multiSelectViewTeam";
            this.multiSelectViewTeam.Size = new System.Drawing.Size(498, 735);
            this.multiSelectViewTeam.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.groupBoxUsers, 0, 1);
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
            this.groupBoxFilter.Text = "User Filter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxUserViews, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUserName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearchUser, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelUsersView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelUsersName, 0, 1);
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
            // buttonSearchUser
            // 
            this.buttonSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchUser.Location = new System.Drawing.Point(133, 53);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(189, 19);
            this.buttonSearchUser.TabIndex = 6;
            this.buttonSearchUser.Text = "Search And Load Users";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            // 
            // labelUsersView
            // 
            this.labelUsersView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUsersView.AutoSize = true;
            this.labelUsersView.Location = new System.Drawing.Point(29, 6);
            this.labelUsersView.Name = "labelUsersView";
            this.labelUsersView.Size = new System.Drawing.Size(98, 13);
            this.labelUsersView.TabIndex = 7;
            this.labelUsersView.Text = "Select User\'s View:";
            // 
            // labelUsersName
            // 
            this.labelUsersName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUsersName.AutoSize = true;
            this.labelUsersName.Location = new System.Drawing.Point(20, 31);
            this.labelUsersName.Name = "labelUsersName";
            this.labelUsersName.Size = new System.Drawing.Size(107, 13);
            this.labelUsersName.TabIndex = 8;
            this.labelUsersName.Text = "User Name Contains:";
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.dataGridUsers);
            this.groupBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUsers.Location = new System.Drawing.Point(3, 103);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(331, 667);
            this.groupBoxUsers.TabIndex = 1;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Users:";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToOrderColumns = true;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id,
            this.UserName,
            this.BusinessUnit});
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 16);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(325, 648);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridUsers_DataBindingComplete);
            this.dataGridUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridUsers_Paint);
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
            this.tabControlUSM.Controls.Add(this.tabPageFSPsAndOthers);
            this.tabControlUSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUSM.Location = new System.Drawing.Point(0, 0);
            this.tabControlUSM.Name = "tabControlUSM";
            this.tabControlUSM.SelectedIndex = 0;
            this.tabControlUSM.Size = new System.Drawing.Size(1022, 773);
            this.tabControlUSM.TabIndex = 0;
            // 
            // tabPageFSPsAndOthers
            // 
            this.tabPageFSPsAndOthers.Controls.Add(this.tableLayoutPanel4);
            this.tabPageFSPsAndOthers.Location = new System.Drawing.Point(4, 22);
            this.tabPageFSPsAndOthers.Name = "tabPageFSPsAndOthers";
            this.tabPageFSPsAndOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFSPsAndOthers.Size = new System.Drawing.Size(1014, 747);
            this.tabPageFSPsAndOthers.TabIndex = 1;
            this.tabPageFSPsAndOthers.Text = "Field Security Profiles & Others";
            this.tabPageFSPsAndOthers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.multiSelectViewFSP, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1008, 741);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // multiSelectViewFSP
            // 
            this.multiSelectViewFSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSelectViewFSP.Location = new System.Drawing.Point(3, 3);
            this.multiSelectViewFSP.MultiSelectName = null;
            this.multiSelectViewFSP.Name = "multiSelectViewFSP";
            this.multiSelectViewFSP.Size = new System.Drawing.Size(498, 735);
            this.multiSelectViewFSP.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxDirectAndTeamFSPs, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBoxDirectAndTeamRoles, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(507, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(498, 735);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // groupBoxDirectAndTeamFSPs
            // 
            this.groupBoxDirectAndTeamFSPs.Controls.Add(this.dataGridViewDirectAndTeamFSPs);
            this.groupBoxDirectAndTeamFSPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDirectAndTeamFSPs.Location = new System.Drawing.Point(3, 360);
            this.groupBoxDirectAndTeamFSPs.Name = "groupBoxDirectAndTeamFSPs";
            this.groupBoxDirectAndTeamFSPs.Size = new System.Drawing.Size(492, 351);
            this.groupBoxDirectAndTeamFSPs.TabIndex = 2;
            this.groupBoxDirectAndTeamFSPs.TabStop = false;
            this.groupBoxDirectAndTeamFSPs.Text = "All Assigned Field Security Profiles (Direct and Team):";
            // 
            // dataGridViewDirectAndTeamFSPs
            // 
            this.dataGridViewDirectAndTeamFSPs.AllowUserToAddRows = false;
            this.dataGridViewDirectAndTeamFSPs.AllowUserToDeleteRows = false;
            this.dataGridViewDirectAndTeamFSPs.AllowUserToOrderColumns = true;
            this.dataGridViewDirectAndTeamFSPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectAndTeamFSPs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FSPName,
            this.FSPTeamName,
            this.FSPTeamBusinessUnit});
            this.dataGridViewDirectAndTeamFSPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDirectAndTeamFSPs.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDirectAndTeamFSPs.Name = "dataGridViewDirectAndTeamFSPs";
            this.dataGridViewDirectAndTeamFSPs.ReadOnly = true;
            this.dataGridViewDirectAndTeamFSPs.RowHeadersVisible = false;
            this.dataGridViewDirectAndTeamFSPs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDirectAndTeamFSPs.Size = new System.Drawing.Size(486, 332);
            this.dataGridViewDirectAndTeamFSPs.TabIndex = 1;
            this.dataGridViewDirectAndTeamFSPs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDirectAndTeamFSPs_DataBindingComplete);
            this.dataGridViewDirectAndTeamFSPs.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewDirectAndTeamFSPs_Paint);
            // 
            // FSPName
            // 
            this.FSPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FSPName.DataPropertyName = "Name";
            this.FSPName.HeaderText = "Name";
            this.FSPName.Name = "FSPName";
            this.FSPName.ReadOnly = true;
            // 
            // FSPTeamName
            // 
            this.FSPTeamName.DataPropertyName = "TeamName";
            this.FSPTeamName.HeaderText = "Team Name";
            this.FSPTeamName.Name = "FSPTeamName";
            this.FSPTeamName.ReadOnly = true;
            // 
            // FSPTeamBusinessUnit
            // 
            this.FSPTeamBusinessUnit.DataPropertyName = "TeamBusinessUnitName";
            this.FSPTeamBusinessUnit.HeaderText = "Team Business Unit";
            this.FSPTeamBusinessUnit.Name = "FSPTeamBusinessUnit";
            this.FSPTeamBusinessUnit.ReadOnly = true;
            // 
            // groupBoxDirectAndTeamRoles
            // 
            this.groupBoxDirectAndTeamRoles.Controls.Add(this.dataGridViewDirectAndTeamRoles);
            this.groupBoxDirectAndTeamRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDirectAndTeamRoles.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDirectAndTeamRoles.Name = "groupBoxDirectAndTeamRoles";
            this.groupBoxDirectAndTeamRoles.Size = new System.Drawing.Size(492, 351);
            this.groupBoxDirectAndTeamRoles.TabIndex = 2;
            this.groupBoxDirectAndTeamRoles.TabStop = false;
            this.groupBoxDirectAndTeamRoles.Text = "All Assigned Roles (Direct and Team):";
            // 
            // dataGridViewDirectAndTeamRoles
            // 
            this.dataGridViewDirectAndTeamRoles.AllowUserToAddRows = false;
            this.dataGridViewDirectAndTeamRoles.AllowUserToDeleteRows = false;
            this.dataGridViewDirectAndTeamRoles.AllowUserToOrderColumns = true;
            this.dataGridViewDirectAndTeamRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectAndTeamRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleName,
            this.RoleBusinessUnit,
            this.RoleTeamName,
            this.TeamBusinessUnit});
            this.dataGridViewDirectAndTeamRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDirectAndTeamRoles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDirectAndTeamRoles.Name = "dataGridViewDirectAndTeamRoles";
            this.dataGridViewDirectAndTeamRoles.ReadOnly = true;
            this.dataGridViewDirectAndTeamRoles.RowHeadersVisible = false;
            this.dataGridViewDirectAndTeamRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDirectAndTeamRoles.Size = new System.Drawing.Size(486, 332);
            this.dataGridViewDirectAndTeamRoles.TabIndex = 0;
            this.dataGridViewDirectAndTeamRoles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDirectAndTeamRoles_DataBindingComplete);
            this.dataGridViewDirectAndTeamRoles.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewDirectAndTeamRoles_Paint);
            // 
            // RoleName
            // 
            this.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleName.DataPropertyName = "Name";
            this.RoleName.HeaderText = "Name";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // RoleBusinessUnit
            // 
            this.RoleBusinessUnit.DataPropertyName = "BusinessUnitName";
            this.RoleBusinessUnit.HeaderText = "Business Unit";
            this.RoleBusinessUnit.Name = "RoleBusinessUnit";
            this.RoleBusinessUnit.ReadOnly = true;
            // 
            // RoleTeamName
            // 
            this.RoleTeamName.DataPropertyName = "TeamName";
            this.RoleTeamName.HeaderText = "Team Name";
            this.RoleTeamName.Name = "RoleTeamName";
            this.RoleTeamName.ReadOnly = true;
            // 
            // TeamBusinessUnit
            // 
            this.TeamBusinessUnit.DataPropertyName = "TeamBusinessUnitName";
            this.TeamBusinessUnit.HeaderText = "Team Business Unit";
            this.TeamBusinessUnit.Name = "TeamBusinessUnit";
            this.TeamBusinessUnit.ReadOnly = true;
            // 
            // UserSecurityManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerUserSecurityManager);
            this.Name = "UserSecurityManagerView";
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
            this.groupBoxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.tabControlUSM.ResumeLayout(false);
            this.tabPageFSPsAndOthers.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxDirectAndTeamFSPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectAndTeamFSPs)).EndInit();
            this.groupBoxDirectAndTeamRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectAndTeamRoles)).EndInit();
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
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TabControl tabControlUSM;
        private System.Windows.Forms.TabPage tabPageFSPsAndOthers;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBoxDirectAndTeamFSPs;
        private System.Windows.Forms.DataGridView dataGridViewDirectAndTeamFSPs;
        private System.Windows.Forms.GroupBox groupBoxDirectAndTeamRoles;
        private System.Windows.Forms.DataGridView dataGridViewDirectAndTeamRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleBusinessUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamBusinessUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSPTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSPTeamBusinessUnit;
        private System.Windows.Forms.Label labelUsersView;
        private System.Windows.Forms.Label labelUsersName;
    }
}
