using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    [Serializable]
    public class FilterList : IFilterMatchable
    {
        private GenericArrayList<LogFilter> Filters;

        public FilterList()
        {
            Filters = new GenericArrayList<LogFilter>();
        }

        public void AddFilter(LogFilter filter)
        {
            Filters.Add(filter);
        }

        public bool Match(LogEntry log)
        {
            bool stat = false;

            Filters.Iterate(delegate(LogFilter filter) 
            {
                if (filter.Match(log))
                {
                    stat = true;
                    return true;
                }

                return false;
            });

            return stat;
        }

        public int Count
        {
            get { return Filters.Count; }
        }
    }
}
