using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace yald
{
    public enum DebugType
    {
        Unknown,
        Info,
        Debug,
        Warning,
        Error,
        Verbose
    }

    public class LogEntry
    {
        private DebugType LogType;
        private string LogTag;
        private int Pid;
        private string LogMsg;

        private DebugType GetDebugTypeFromIdentifier(char Id)
        {
            switch (Id)
            {
                case 'I':
                    return DebugType.Info;
                case 'D':
                    return DebugType.Debug;
                case 'W':
                    return DebugType.Warning;
                case 'E':
                    return DebugType.Error;
                case 'V':
                    return DebugType.Verbose;
                default:
                    return DebugType.Unknown;
            }
        }

        public static LogEntry Parse(string LogLine)
        {
            Regex rg = new Regex("([DVIWE])/(.*?) ?\\((.*?)\\): (.*)");
            Match m = rg.Match(LogLine);
            LogEntry LogObj = null;
            char type;
            string tag;
            int pid;
            string msg;

            if (m.Groups.Count == 5)
            {
                type = m.Groups[1].Value[0];
                tag = m.Groups[2].Value;

                try
                {
                    pid = int.Parse(m.Groups[3].Value.Trim());
                }
                catch 
                { 
                    return null; 
                }

                msg = m.Groups[4].Value;

                try
                {
                    LogObj = new LogEntry(type, tag, pid, msg);
                }
                catch { }
            }

            return LogObj;
        }

        public LogEntry(char TypeId, string Tag, int Pid, string Message)
        {
            this.LogType = GetDebugTypeFromIdentifier(TypeId);

            if (this.LogType == DebugType.Unknown)
                throw new Exception("Unknown DebugType identifier");

            this.LogTag = Tag;
            this.Pid = Pid;
            this.LogMsg = Message;
        }


        public DebugType Type
        {
            get { return this.LogType; }
        }

        public string Tag
        {
            get { return this.LogTag; }
        }

        public int ProcessId
        {
            get { return this.Pid; }
        }

        public string Message
        {
            get { return this.LogMsg; }
        }

        public override string ToString()
        {
            return string.Format("[{0}] - ({1}) {2} - {3}",
                ProcessId,
                Type.ToString(),
                Tag,
                Message);
        }

    }
}
