using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yald
{
    public partial class frmNewFilter : Form
    {
        public frmNewFilter()
        {
            InitializeComponent();
        }

        FilterList Filters = new FilterList();
        string FilterName;

        private LogFilter GetFilterObjectFromUI()
        {
            LogFilter FilterObj = null;

            object BoxVal = 0;
            FilterOperator Op = (FilterOperator)cbFilterOp.SelectedIndex;
            FilterSection Sect = (FilterSection)cbFilterSection.SelectedIndex;
            DebugType DebType = (DebugType)(cbSectionValues.SelectedIndex + 1);
            string StrValue = txtValue.Text;

            switch (Sect)
            {
                case FilterSection.LogTypeSection:
                    BoxVal = DebType;
                    break;
                case FilterSection.TagSection:
                case FilterSection.MessageSection:
                    BoxVal = txtValue.Text;
                    break;
                case FilterSection.PidSection:
                    {
                        try
                        {
                            BoxVal = int.Parse(StrValue);
                        }
                        catch { }

                        break;
                    }
            }

            
            FilterObj = new LogFilter(Op, BoxVal, Sect);

            FilterObj.UseRegexp = chkUseRegexp.Checked;

            return FilterObj;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LogFilter Filter = GetFilterObjectFromUI();

            Filters.AddFilter(Filter);
            lstFilterPool.Items.Add(Filter);

        }

        private void frmNewFilter_Load(object sender, EventArgs e)
        {
            cbFilterOp.SelectedIndex = 0;
            cbFilterSection.SelectedIndex = 0;
            cbSectionValues.SelectedIndex = 0;
        }

        private void cbFilterSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSectionValues.Visible = cbFilterSection.SelectedIndex == 0;
        }



        public FilterList GetFilterList()
        {
            return (Filters.Count == 0) ? null : Filters;
        }

        public string GetFilterName()
        {
            return FilterName;
        }

        public bool GetLinkState()
        {
            return chkLinkRulesAnd.Checked;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FilterName = txtFilterName.Text;
            this.Close();
        }

    }
}
