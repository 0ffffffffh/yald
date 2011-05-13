namespace yald
{
    partial class TabContent
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
            this.lstLogs = new DoubleBufferedListView();
            this.clmLogTime = new System.Windows.Forms.ColumnHeader();
            this.clmTag = new System.Windows.Forms.ColumnHeader();
            this.clmPid = new System.Windows.Forms.ColumnHeader();
            this.clmLogMsg = new System.Windows.Forms.ColumnHeader();
            this.clmTagType = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lstLogs
            // 
            this.lstLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmLogTime,
            this.clmTagType,
            this.clmPid,
            this.clmTag,
            this.clmLogMsg});
            this.lstLogs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstLogs.FullRowSelect = true;
            this.lstLogs.Location = new System.Drawing.Point(12, 16);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(532, 325);
            this.lstLogs.TabIndex = 0;
            this.lstLogs.UseCompatibleStateImageBehavior = false;
            this.lstLogs.View = System.Windows.Forms.View.Details;
            // 
            // clmLogTime
            // 
            this.clmLogTime.Text = "Log Time";
            this.clmLogTime.Width = 119;
            // 
            // clmTag
            // 
            this.clmTag.Text = "Tag";
            this.clmTag.Width = 102;
            // 
            // clmPid
            // 
            this.clmPid.Text = "Pid";
            // 
            // clmLogMsg
            // 
            this.clmLogMsg.Text = "Log Message";
            this.clmLogMsg.Width = 124;
            // 
            // clmTagType
            // 
            this.clmTagType.Text = "Level";
            this.clmTagType.Width = 108;
            // 
            // TabContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstLogs);
            this.Name = "TabContent";
            this.Size = new System.Drawing.Size(573, 373);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TabContent_Paint);
            this.Resize += new System.EventHandler(this.TabContent_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedListView lstLogs;
        private System.Windows.Forms.ColumnHeader clmLogTime;
        private System.Windows.Forms.ColumnHeader clmTag;
        private System.Windows.Forms.ColumnHeader clmPid;
        private System.Windows.Forms.ColumnHeader clmLogMsg;
        private System.Windows.Forms.ColumnHeader clmTagType;
    }
}
