namespace yald
{
    partial class frmFilters
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
            this.lstFilters = new System.Windows.Forms.CheckedListBox();
            this.btnRemSelected = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstFilters
            // 
            this.lstFilters.FormattingEnabled = true;
            this.lstFilters.Location = new System.Drawing.Point(12, 24);
            this.lstFilters.Name = "lstFilters";
            this.lstFilters.Size = new System.Drawing.Size(370, 244);
            this.lstFilters.TabIndex = 0;
            // 
            // btnRemSelected
            // 
            this.btnRemSelected.Location = new System.Drawing.Point(151, 274);
            this.btnRemSelected.Name = "btnRemSelected";
            this.btnRemSelected.Size = new System.Drawing.Size(136, 27);
            this.btnRemSelected.TabIndex = 1;
            this.btnRemSelected.Text = "Remove Selected Filters";
            this.btnRemSelected.UseVisualStyleBackColor = true;
            this.btnRemSelected.Click += new System.EventHandler(this.btnRemSelected_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(293, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 27);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(14, 5);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 17);
            this.chkAll.TabIndex = 3;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 311);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRemSelected);
            this.Controls.Add(this.lstFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFilters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.frmFilters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstFilters;
        private System.Windows.Forms.Button btnRemSelected;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkAll;
    }
}