using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    class EntryList
    {
        private GenericArrayList<LogEntry> Entires;
        private FilterList Filters;

        public EntryList()
        {
            Entires = new GenericArrayList<LogEntry>();
        }

        public void AddEntry(LogEntry entry)
        {
            Entires.Add(entry);
        }

        public void SetFilter(FilterList filters)
        {
            Filters = filters;
        }

        public void Clear()
        {
            if (Filters != null)
                Filters.Clear();

            if (Entires != null)
                Entires.Clear();
        }

        public int Count
        {
            get { return Entires.Count; }
        }

    }
}
