using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace yald
{
    public partial class frmMain : Form
    {
        LogcatManager logcat = new LogcatManager();
        List<UserFilterObject> UserFilters;

        public frmMain()
        {
            InitializeComponent();
        }

        private TabContent AddTabContentToPage(TabPage Page, string Name, bool SelectTab)
        {
            TabContent ContentObj = new TabContent();
            Page.Name = Name;
            Page.Text = Name;

            Page.Controls.Add(ContentObj);

            if (tbFilterContainer.TabPages.IndexOf(Page) == -1)
                tbFilterContainer.TabPages.Add(Page);

            if (SelectTab)
                tbFilterContainer.SelectedTab = Page;

            return ContentObj;
        }

        private TabContent AddNewTab(string name, bool select)
        {
            TabPage NewPage = new TabPage();

            return AddTabContentToPage(NewPage, name, true);
        }

        private TabContent InitGeneralTab()
        {
            return AddTabContentToPage(tbGeneralTab, "All Logs", false);
        }

        private void LocateTabs()
        {
            tbFilterContainer.Left = 0;
            tbFilterContainer.Width = this.Width;
            tbFilterContainer.Height = this.ClientSize.Height - statusBar.Height;

            tbFilterContainer.SelectedTab.Invalidate();
        }

        private void SaveAdbLocation(string loc)
        {
            if (string.IsNullOrEmpty(loc))
                return;

            try
            {
                StreamWriter AdbLocation = new StreamWriter("adbsetting.stg");
                AdbLocation.Write(loc);
                AdbLocation.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("An error occurred while writing adb location\n" +
                                e.Message);
            }
        }

        private string LoadAdbLocation()
        {
            string loc;

            try
            {
                StreamReader AdbLocation = new StreamReader("adbsetting.stg");
                loc = AdbLocation.ReadLine();
                AdbLocation.Close();
                return loc;
            }
            catch (FileNotFoundException)
            {
                //I dont want show message in this exception type
            }
            catch (Exception e)
            {

                MessageBox.Show("An error occurred while reading adb location\n" +
                                 e.Message);
            }

            return "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TabContent TabContentObj;

            UserFilters = UserFilterObject.LoadFilters("filter.flt");

            TabContentObj = InitGeneralTab();
            logcat.GeneralTabContent = TabContentObj;
            logcat.OnDeviceConnected += new LogcatManager.DeviceConnectedEventHandler(logcat_OnDeviceConnected);
            logcat.Adb = LoadAdbLocation();

            if (UserFilters == null)
                UserFilters = new List<UserFilterObject>();
            else
            {
                foreach (UserFilterObject filter in UserFilters)
                {
                    TabContentObj = AddNewTab(filter.Name, false);
                    logcat.AddSlot(filter.Name, filter.FilterObject).LinkUi(TabContentObj);
                }
            }

            LocateTabs();
        }

        void logcat_OnDeviceConnected()
        {
            this.Invoke(new MethodInvoker(delegate()
                {
                    lblStatus.Text = "Device connected";
                    prgStatusProgress.Style = ProgressBarStyle.Blocks;
                }));
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            LocateTabs();
        }

        private void addNewFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabContent NewTabContentObj;
            string Name;
            FilterList List;
            bool LinkState;

            UserFilterObject UserFilter;

            frmNewFilter filter = new frmNewFilter();
            filter.ShowDialog();

            if (filter.GetFilterList() == null)
                return;

            Name = filter.GetFilterName();
            List = filter.GetFilterList();
            LinkState = filter.GetLinkState();

            UserFilter = new UserFilterObject(List, Name, LinkState);

            UserFilters.Add(UserFilter);
            UserFilterObject.SaveFilters(UserFilters, "filter.flt");


            NewTabContentObj = AddNewTab(Name, true);

            logcat.AddSlot(Name, List).LinkUi(NewTabContentObj);

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Stop")
            {
                logcat.Stop();
                startToolStripMenuItem.Text = "Start";
                return;
            }

            try
            {

                if (!logcat.Start())
                {
                    lblStatus.Text = "adb could not start";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            startToolStripMenuItem.Text = "Stop";
            lblStatus.Text = "Waiting for device...";
            prgStatusProgress.Style = ProgressBarStyle.Marquee;
            
        }

        private void setADBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog AdbFile = new OpenFileDialog();
            AdbFile.ShowDialog();

            logcat.Adb = AdbFile.FileName;

            SaveAdbLocation(AdbFile.FileName);

        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericArrayList<UserFilterObject> RemovedObjects;
            TabPage CurrTab;

            frmFilters FiltersDlg = new frmFilters(UserFilters);
            FiltersDlg.ShowDialog();

            RemovedObjects = FiltersDlg.GetRemovedObjects();

            if (RemovedObjects.Count > 0)
            {
                //perform real deleting operation

                foreach (UserFilterObject filter in RemovedObjects)
                {
                    logcat.RemoveSlot(filter.Name);

                    for (int i = 0; i < tbFilterContainer.TabPages.Count; i++)
                    {
                        CurrTab = tbFilterContainer.TabPages[i];

                        if (CurrTab.Text == filter.Name)
                        {
                            tbFilterContainer.TabPages.Remove(CurrTab);
                            CurrTab.Dispose();
                        }
                    }
                }

                RemovedObjects.Clear();

                UserFilterObject.SaveFilters(UserFilters, "filter.flt");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout AboutDlg = new frmAbout();
            AboutDlg.ShowDialog();
        }
    }
}
