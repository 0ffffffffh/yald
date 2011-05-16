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

        public void Clear()
        {
            if (Filters != null)
                Filters.Clear();
        }

        public bool Match(LogEntry log)
        {
            bool stat = false;
            int MatchCount = 0;


            Filters.Iterate(delegate(LogFilter filter) 
            {
                if (filter.Match(log))
                {
                    if (LinkWithAnd)
                    {
                        MatchCount++;
                        return false;
                    }

                    stat = true;
                    return true;
                }

                return false;
            });


            if (LinkWithAnd && Filters.Count == MatchCount)
                stat = true;

            return stat;
        }

        public int Count
        {
            get { return Filters.Count; }
        }

        public bool LinkWithAnd
        {
            get;
            set;
        }
    }
}
