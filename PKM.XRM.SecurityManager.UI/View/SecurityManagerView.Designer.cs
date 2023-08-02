namespace PKM.XRM.SecurityManager.UI.View
{
    partial class SecurityManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityManagerView));
            this.buttonSecurityReport = new System.Windows.Forms.Button();
            this.buttonFSPM = new System.Windows.Forms.Button();
            this.buttonSRM = new System.Windows.Forms.Button();
            this.buttonUSM = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buttonTSM = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSecurityReport
            // 
            this.buttonSecurityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecurityReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSecurityReport.ForeColor = System.Drawing.Color.Black;
            this.buttonSecurityReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonSecurityReport.Image")));
            this.buttonSecurityReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSecurityReport.Location = new System.Drawing.Point(-2, 220);
            this.buttonSecurityReport.Name = "buttonSecurityReport";
            this.buttonSecurityReport.Size = new System.Drawing.Size(206, 43);
            this.buttonSecurityReport.TabIndex = 7;
            this.buttonSecurityReport.Text = "   Security Reports";
            this.buttonSecurityReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSecurityReport.UseVisualStyleBackColor = true;
            this.buttonSecurityReport.Visible = false;
            // 
            // buttonFSPM
            // 
            this.buttonFSPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFSPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFSPM.ForeColor = System.Drawing.Color.Black;
            this.buttonFSPM.Image = ((System.Drawing.Image)(resources.GetObject("buttonFSPM.Image")));
            this.buttonFSPM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFSPM.Location = new System.Drawing.Point(-2, 132);
            this.buttonFSPM.Name = "buttonFSPM";
            this.buttonFSPM.Size = new System.Drawing.Size(206, 43);
            this.buttonFSPM.TabIndex = 6;
            this.buttonFSPM.Text = "   Field Security Profile";
            this.buttonFSPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFSPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFSPM.UseVisualStyleBackColor = true;
            // 
            // buttonSRM
            // 
            this.buttonSRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSRM.ForeColor = System.Drawing.Color.Black;
            this.buttonSRM.Image = ((System.Drawing.Image)(resources.GetObject("buttonSRM.Image")));
            this.buttonSRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSRM.Location = new System.Drawing.Point(-2, 176);
            this.buttonSRM.Name = "buttonSRM";
            this.buttonSRM.Size = new System.Drawing.Size(206, 43);
            this.buttonSRM.TabIndex = 5;
            this.buttonSRM.Text = "   Security Roles";
            this.buttonSRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSRM.UseVisualStyleBackColor = true;
            // 
            // buttonUSM
            // 
            this.buttonUSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSM.ForeColor = System.Drawing.Color.Black;
            this.buttonUSM.Image = ((System.Drawing.Image)(resources.GetObject("buttonUSM.Image")));
            this.buttonUSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUSM.Location = new System.Drawing.Point(-2, 44);
            this.buttonUSM.Name = "buttonUSM";
            this.buttonUSM.Size = new System.Drawing.Size(206, 43);
            this.buttonUSM.TabIndex = 4;
            this.buttonUSM.Text = "   User Security";
            this.buttonUSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUSM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUSM.UseVisualStyleBackColor = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(50, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(149, 20);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Security Manager";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(3, 1);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(44, 43);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.headerPanel.Controls.Add(this.pictureBoxClose);
            this.headerPanel.Controls.Add(this.labelHeader);
            this.headerPanel.Controls.Add(this.pictureLogo);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(958, 45);
            this.headerPanel.TabIndex = 5;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(923, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(32, 45);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(-2, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(206, 43);
            this.buttonMenu.TabIndex = 10;
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.leftPanel.Controls.Add(this.buttonSecurityReport);
            this.leftPanel.Controls.Add(this.buttonTSM);
            this.leftPanel.Controls.Add(this.buttonMenu);
            this.leftPanel.Controls.Add(this.buttonFSPM);
            this.leftPanel.Controls.Add(this.buttonSRM);
            this.leftPanel.Controls.Add(this.buttonUSM);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 45);
            this.leftPanel.MaximumSize = new System.Drawing.Size(200, 0);
            this.leftPanel.MinimumSize = new System.Drawing.Size(40, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 583);
            this.leftPanel.TabIndex = 6;
            // 
            // buttonTSM
            // 
            this.buttonTSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTSM.ForeColor = System.Drawing.Color.Black;
            this.buttonTSM.Image = ((System.Drawing.Image)(resources.GetObject("buttonTSM.Image")));
            this.buttonTSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTSM.Location = new System.Drawing.Point(-2, 88);
            this.buttonTSM.Name = "buttonTSM";
            this.buttonTSM.Size = new System.Drawing.Size(206, 43);
            this.buttonTSM.TabIndex = 11;
            this.buttonTSM.Text = "   Team Security";
            this.buttonTSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTSM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTSM.UseVisualStyleBackColor = true;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(200, 45);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(758, 583);
            this.bodyPanel.TabIndex = 7;
            // 
            // SecurityManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "SecurityManagerView";
            this.Size = new System.Drawing.Size(958, 628);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSecurityReport;
        private System.Windows.Forms.Button buttonFSPM;
        private System.Windows.Forms.Button buttonSRM;
        private System.Windows.Forms.Button buttonUSM;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button buttonTSM;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}
