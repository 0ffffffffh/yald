using System;
using System.Collections.Generic;
using System.Text;

namespace yald
{
    interface IFilterMatchable
    {
        bool Match(LogEntry log);
    }
}
