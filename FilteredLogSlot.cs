using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    class FilteredLogSlot : IDisposable
    {
        private EntryList FilteredList;
        private FilterList SlotFilters;
        private TabContent Ui;
        private bool Disposed = false;
        private string SlotName;

        public FilteredLogSlot(string Slotname, FilterList Filters)
        {
            FilteredList = new EntryList();
            SlotFilters = Filters;
            SlotName = Slotname;
        }

        private void CheckDisposed()
        {
            if (Disposed)
                throw new Exception("Object disposed!");
        }

        public string Name
        {
            get { return SlotName; }
        }

        public int FilterCount
        {
            get
            {
                CheckDisposed();
                return SlotFilters.Count;
            }
        }

        public void LinkUi(TabContent content)
        {
            CheckDisposed();

            Ui = content;
        }

        public bool TryAdd(LogEntry entry)
        {
            CheckDisposed();

            if (SlotFilters.Match(entry))
            {
                if (Ui.InvokeRequired)
                {
                    Ui.Invoke(new System.Windows.Forms.MethodInvoker(delegate()
                        {
                            Ui.WriteLog(entry);
                        }));
                }

                FilteredList.AddEntry(entry);
                return true;
            }

            return false;
        }


        public void Dispose()
        {
            CheckDisposed();

            FilteredList.Clear();
            FilteredList = null;
            SlotFilters.Clear();
            SlotFilters = null;
            Ui.ClearTab();
            Ui.Dispose();
            Ui = null;
            Disposed = true;
        }
    }
}
