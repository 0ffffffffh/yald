using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace yald
{
    public partial class TabContent : UserControl
    {
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam,IntPtr lParam);

        public TabContent()
        {
            InitializeComponent();
        }

        public ListView GetListView()
        {
            return lstLogs;
        }

        public void ClearTab()
        {
            lstLogs.Items.Clear();
            lstLogs.Dispose();
        }

        public void WriteLog(LogEntry log)
        {
            Color color = Color.Teal;

            ListViewItem lvi = new ListViewItem();

            switch (log.Type)
            {
                case DebugType.Debug:
                    color = Color.Blue;
                    break;
                case DebugType.Error:
                    color = Color.DarkRed;
                    break;
                case DebugType.Info:
                    color = Color.Green;
                    break;
                case DebugType.Verbose:
                    color = Color.Black;
                    break;
                case DebugType.Warning:
                    color = Color.Orange;
                    break;
            }

            lvi.ForeColor = color;
            lvi.Text = DateTime.Now.ToString();

            lvi.SubItems.AddRange(new string[] {
                                                log.Type.ToString(),
                                                log.ProcessId.ToString(),
                                                log.Tag,
                                                log.Message});

            lstLogs.Items.Add(lvi);

            SendMessage(lstLogs.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);

            
        }

        private void TabContent_Resize(object sender, EventArgs e)
        {
        }

        private int GetPercentOf(int Value, int Percent)
        {
            return (Value * Percent) / 100;
        }

        private void TabContent_Paint(object sender, PaintEventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Parent.Width;
            this.Height = Parent.Height;


            lstLogs.Left = 10;
            lstLogs.Top = 10;
            lstLogs.Width = this.Width - 35;
            lstLogs.Height = this.Height - 45;

            lstLogs.Columns[0].Width = GetPercentOf(lstLogs.Width, 20);
            lstLogs.Columns[1].Width = GetPercentOf(lstLogs.Width, 10);
            lstLogs.Columns[2].Width = GetPercentOf(lstLogs.Width, 10);
            lstLogs.Columns[3].Width = GetPercentOf(lstLogs.Width, 15);
            lstLogs.Columns[4].Width = GetPercentOf(lstLogs.Width, 44);


        }
    }
}
