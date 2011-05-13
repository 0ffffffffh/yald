using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    class LogcatManager
    {
        public delegate void DeviceConnectedEventHandler();

        private GenericArrayList<FilteredLogSlot> Slots;
        private EntryList GeneralEntries;
        private TabContent GeneralTabUi;
        private string AdbExecutable;
        ProcessObject LogcatProcess;

        public LogcatManager()
        {
            Slots = new GenericArrayList<FilteredLogSlot>(10);
            GeneralEntries = new EntryList();

            LogcatProcess = new ProcessObject(@"C:\Users\Oguz Kartal\Desktop\android-sdk-windows\tools\adb.exe", "logcat");
            LogcatProcess.OnLineOutputReceive += new ProcessObject.ConsoleLineOutputHandler(LogcatProcess_OnLineOutputReceive);
        }

        void LogcatProcess_OnLineOutputReceive(string line)
        {

            if (line == "DEVCON")
            {
                if (OnDeviceConnected != null)
                    OnDeviceConnected();

                return;
            }

            LogEntry entry = LogEntry.Parse(line);
            bool IsGeneralEntry = true;

            Slots.Iterate(delegate(FilteredLogSlot slot)
            {
                if (slot.TryAdd(entry))
                {
                    IsGeneralEntry = false;
                    return true;
                }

                IsGeneralEntry = true;
                return false;
            });



            if (IsGeneralEntry)
            {
                GeneralEntries.AddEntry(entry);

                if (GeneralTabUi.InvokeRequired)
                {
                    GeneralTabUi.Invoke(new System.Windows.Forms.MethodInvoker(delegate()
                        {
                            GeneralTabUi.WriteLog(entry);
                        }));
                }
            }
        }

        public FilteredLogSlot AddSlot(string Name, FilterList Filters)
        {
            FilteredLogSlot Slot = null;

            if (string.IsNullOrEmpty(Name) || Filters == null)
                return null;

            Slot = new FilteredLogSlot(Name, Filters);
            Slots.Add(Slot);
            return Slot;
        }

        public void Stop()
        {
            LogcatProcess.Kill();
        }

        public bool Start()
        {
            LogcatProcess.Start();

            return LogcatProcess.IsRunning;
        }

        public TabContent GeneralTabContent
        {
            get
            {
                return GeneralTabUi;
            }
            set
            {
                GeneralTabUi = value;
            }
        }

        public string Adb
        {
            get { return AdbExecutable; }
            set { AdbExecutable = value; }
        }

        public event DeviceConnectedEventHandler OnDeviceConnected;


    }
}
