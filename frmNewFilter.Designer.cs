namespace yald
{
    partial class frmNewFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterSection = new System.Windows.Forms.ComboBox();
            this.cbFilterOp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.chkUseRegexp = new System.Windows.Forms.CheckBox();
            this.cbSectionValues = new System.Windows.Forms.ComboBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstFilterPool = new System.Windows.Forms.ListBox();
            this.chkLinkRulesAnd = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Section:";
            // 
            // cbFilterSection
            // 
            this.cbFilterSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterSection.FormattingEnabled = true;
            this.cbFilterSection.Items.AddRange(new object[] {
            "Debug Level",
            "Tag",
            "Process Id",
            "Message"});
            this.cbFilterSection.Location = new System.Drawing.Point(95, 32);
            this.cbFilterSection.Name = "cbFilterSection";
            this.cbFilterSection.Size = new System.Drawing.Size(166, 21);
            this.cbFilterSection.TabIndex = 1;
            this.cbFilterSection.SelectedIndexChanged += new System.EventHandler(this.cbFilterSection_SelectedIndexChanged);
            // 
            // cbFilterOp
            // 
            this.cbFilterOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterOp.FormattingEnabled = true;
            this.cbFilterOp.Items.AddRange(new object[] {
            "Equal",
            "Not Equal",
            "Greater",
            "Lower",
            "Greater And Equal",
            "Lower And Equal",
            "Contain",
            "Not Contain"});
            this.cbFilterOp.Location = new System.Drawing.Point(95, 59);
            this.cbFilterOp.Name = "cbFilterOp";
            this.cbFilterOp.Size = new System.Drawing.Size(166, 21);
            this.cbFilterOp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter Operation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(95, 92);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(166, 20);
            this.txtValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter Name:";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(107, 19);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(166, 20);
            this.txtFilterName.TabIndex = 7;
            // 
            // chkUseRegexp
            // 
            this.chkUseRegexp.AutoSize = true;
            this.chkUseRegexp.Location = new System.Drawing.Point(122, 118);
            this.chkUseRegexp.Name = "chkUseRegexp";
            this.chkUseRegexp.Size = new System.Drawing.Size(139, 17);
            this.chkUseRegexp.TabIndex = 8;
            this.chkUseRegexp.Text = "Use Regular Expression";
            this.chkUseRegexp.UseVisualStyleBackColor = true;
            // 
            // cbSectionValues
            // 
            this.cbSectionValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectionValues.FormattingEnabled = true;
            this.cbSectionValues.Items.AddRange(new object[] {
            "Information",
            "Debug",
            "Warning",
            "Error",
            "Verbose"});
            this.cbSectionValues.Location = new System.Drawing.Point(95, 92);
            this.cbSectionValues.Name = "cbSectionValues";
            this.cbSectionValues.Size = new System.Drawing.Size(166, 21);
            this.cbSectionValues.TabIndex = 9;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(164, 175);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(97, 28);
            this.btnAddToList.TabIndex = 10;
            this.btnAddToList.Text = "Add to Filter List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilterSection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSectionValues);
            this.groupBox1.Controls.Add(this.cbFilterOp);
            this.groupBox1.Controls.Add(this.chkUseRegexp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 209);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Options";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ok";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lstFilterPool
            // 
            this.lstFilterPool.FormattingEnabled = true;
            this.lstFilterPool.Location = new System.Drawing.Point(326, 13);
            this.lstFilterPool.Name = "lstFilterPool";
            this.lstFilterPool.Size = new System.Drawing.Size(362, 251);
            this.lstFilterPool.TabIndex = 14;
            // 
            // chkLinkRulesAnd
            // 
            this.chkLinkRulesAnd.AutoSize = true;
            this.chkLinkRulesAnd.Location = new System.Drawing.Point(326, 270);
            this.chkLinkRulesAnd.Name = "chkLinkRulesAnd";
            this.chkLinkRulesAnd.Size = new System.Drawing.Size(129, 17);
            this.chkLinkRulesAnd.TabIndex = 11;
            this.chkLinkRulesAnd.Text = "Link rules with \"AND\"";
            this.chkLinkRulesAnd.UseVisualStyleBackColor = true;
            // 
            // frmNewFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 323);
            this.Controls.Add(this.chkLinkRulesAnd);
            this.Controls.Add(this.lstFilterPool);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.label4);
            this.Name = "frmNewFilter";
            this.Text = "Add a New Filter";
            this.Load += new System.EventHandler(this.frmNewFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterSection;
        private System.Windows.Forms.ComboBox cbFilterOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.CheckBox chkUseRegexp;
        private System.Windows.Forms.ComboBox cbSectionValues;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstFilterPool;
        private System.Windows.Forms.CheckBox chkLinkRulesAnd;
    }
}