namespace yald
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbFilterContainer = new System.Windows.Forms.TabControl();
            this.tbGeneralTab = new System.Windows.Forms.TabPage();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setADBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgStatusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFilterContainer.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilterContainer
            // 
            this.tbFilterContainer.Controls.Add(this.tbGeneralTab);
            this.tbFilterContainer.Location = new System.Drawing.Point(0, 27);
            this.tbFilterContainer.Name = "tbFilterContainer";
            this.tbFilterContainer.SelectedIndex = 0;
            this.tbFilterContainer.Size = new System.Drawing.Size(525, 301);
            this.tbFilterContainer.TabIndex = 0;
            // 
            // tbGeneralTab
            // 
            this.tbGeneralTab.Location = new System.Drawing.Point(4, 22);
            this.tbGeneralTab.Name = "tbGeneralTab";
            this.tbGeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeneralTab.Size = new System.Drawing.Size(517, 275);
            this.tbGeneralTab.TabIndex = 0;
            this.tbGeneralTab.Text = "All Logs";
            this.tbGeneralTab.UseVisualStyleBackColor = true;
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(565, 24);
            this.mnMain.TabIndex = 1;
            this.mnMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFilterToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addNewFilterToolStripMenuItem
            // 
            this.addNewFilterToolStripMenuItem.Name = "addNewFilterToolStripMenuItem";
            this.addNewFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewFilterToolStripMenuItem.Text = "Add New Filter";
            this.addNewFilterToolStripMenuItem.Click += new System.EventHandler(this.addNewFilterToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.setADBToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.sToolStripMenuItem.Text = "System";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // setADBToolStripMenuItem
            // 
            this.setADBToolStripMenuItem.Name = "setADBToolStripMenuItem";
            this.setADBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setADBToolStripMenuItem.Text = "Set ADB";
            this.setADBToolStripMenuItem.Click += new System.EventHandler(this.setADBToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.prgStatusProgress});
            this.statusBar.Location = new System.Drawing.Point(0, 336);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(565, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 17);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prgStatusProgress
            // 
            this.prgStatusProgress.Name = "prgStatusProgress";
            this.prgStatusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tbFilterContainer);
            this.Controls.Add(this.mnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Yet Another Logcat Dumper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tbFilterContainer.ResumeLayout(false);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbFilterContainer;
        private System.Windows.Forms.TabPage tbGeneralTab;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar prgStatusProgress;
        private System.Windows.Forms.ToolStripMenuItem setADBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
    }
}

