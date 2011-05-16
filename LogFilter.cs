using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace yald
{
    public enum FilterOperator
    {
        Equal,
        NotEqual,
        Greater,
        Lower,
        GreaterAndEqual,
        LowerAndEqual,
        Contains,
        NotContains
    }

    public enum FilterSection
    {
        LogTypeSection,
        TagSection,
        PidSection,
        MessageSection
    }

    [Serializable]
    public class LogFilter : IFilterMatchable
    {
        private FilterOperator Oper;
        private FilterSection Sect;
        private object Value;

        public LogFilter(FilterOperator Op, object value, FilterSection section)
        {
            Oper = Op;
            Value = value;
            Sect = section;
        }

        private bool DoMatchForLogType(DebugType type)
        {
            switch (Oper)
            {
                case FilterOperator.Equal:
                    return ((DebugType)Value) == type;
                case FilterOperator.NotEqual:
                    return ((DebugType)Value) != type;
                default:
                    return false;
            }
        }

        private bool DoMatchForString(string Str)
        {
            if (UseRegexp)
            {
                try
                {
                    return Regex.IsMatch(Str, (string)Value);
                }
                catch { }
            }

            switch (Oper)
            {
                case FilterOperator.Equal:
                    return ((string)Str).CompareTo((string)Value) == 0;
                case FilterOperator.NotEqual:
                    return ((string)Str).CompareTo((string)Value) != 0;
                case FilterOperator.Contains:
                    return ((string)Str).IndexOf((string)Value, StringComparison.OrdinalIgnoreCase) != -1;
                case FilterOperator.NotContains:
                    return ((string)Str).IndexOf((string)Value, StringComparison.OrdinalIgnoreCase) == -1;
                default:
                    return false;
            }
        }

        private bool DoMatchForInt(int Val)
        {
            switch (Oper)
            {
                case FilterOperator.Equal:
                    return ((int)Value) == Val;
                case FilterOperator.NotEqual:
                    return ((int)Value) != Val;
                case FilterOperator.Greater:
                    return ((int)Value) > Val;
                case FilterOperator.Lower:
                    return ((int)Value) < Val;
                case FilterOperator.GreaterAndEqual:
                    return ((int)Value) >= Val;
                case FilterOperator.LowerAndEqual:
                    return ((int)Value) <= Val;
                default:
                    return false;
            }

        }

        public bool UseRegexp
        {
            get;
            set;
        }
        
        public bool Match(LogEntry log)
        {
            switch (Sect)
            {
                case FilterSection.LogTypeSection:
                    return DoMatchForLogType(log.Type);
                case FilterSection.TagSection:
                    return DoMatchForString(log.Tag);
                case FilterSection.PidSection:
                    return DoMatchForInt(log.ProcessId);
                case FilterSection.MessageSection:
                    return DoMatchForString(log.Message);
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return string.Format("({0}) {1} -> {2}", Oper, Sect, Value);
        }
    }
}
