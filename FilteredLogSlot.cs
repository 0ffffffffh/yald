using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    class FilteredLogSlot
    {
        private EntryList FilteredList;
        private FilterList SlotFilters;
        private TabContent Ui;

        private string SlotName;

        public FilteredLogSlot(string Slotname, FilterList Filters)
        {
            FilteredList = new EntryList();
            SlotFilters = Filters;
            SlotName = Slotname;
        }

        public string Name
        {
            get { return SlotName; }
        }

        public int FilterCount
        {
            get
            {
                return SlotFilters.Count;
            }
        }

        public void LinkUi(TabContent content)
        {
            Ui = content;
        }

        public bool TryAdd(LogEntry entry)
        {
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
    }
}
