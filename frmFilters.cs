using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yald
{
    public partial class frmFilters : Form
    {
        List<UserFilterObject> Filters;
        GenericArrayList<UserFilterObject> ToRemove;

        public frmFilters(List<UserFilterObject> FilterList)
        {
            ToRemove = new GenericArrayList<UserFilterObject>();
            Filters = FilterList;
            InitializeComponent();
        }

        public GenericArrayList<UserFilterObject> GetRemovedObjects()
        {
            return ToRemove;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemSelected_Click(object sender, EventArgs e)
        {
            int selcount = lstFilters.CheckedItems.Count;

            if (selcount < 1)
            {
                MessageBox.Show("Please select to remove items");
                return;
            }

            foreach (UserFilterObject SelItem in lstFilters.CheckedItems)
                ToRemove.Add(SelItem);

            for (int i = 0; i < ToRemove.Count; i++)
            {
                lstFilters.Items.Remove(ToRemove[i]);
                Filters.Remove(ToRemove[i]);
            }
        }

        private void frmFilters_Load(object sender, EventArgs e)
        {
            foreach (UserFilterObject filter in Filters)
            {
                lstFilters.Items.Add(filter);
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
                for (int i = 0; i < lstFilters.Items.Count; i++)
                    lstFilters.SetItemChecked(i, true);

        }
    }
}
