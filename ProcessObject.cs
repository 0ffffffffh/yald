using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace yald
{
    class ProcessObject
    {
        public delegate void ConsoleLineOutputHandler(string line);

        private ProcessStartInfo Psi;
        private Process WorkingProcess;
        private Thread ConsumeWorker;
        private ManualResetEvent WorkerBlock, StartWait;
        private bool Running = false;

        private bool Consume = true;


        public ProcessObject() : this(null,null)
        {
        }

        public ProcessObject(string cmdline) : this(null,cmdline)
        {

        }

        public ProcessObject(string process, string cmdline)
        {
            WorkerBlock = new ManualResetEvent(false);
            StartWait = new ManualResetEvent(false);

            Psi = new ProcessStartInfo();
            Psi.FileName = process;
            Psi.UseShellExecute = false;
            Psi.RedirectStandardOutput = true;
            Psi.RedirectStandardInput = true;
            Psi.Arguments = cmdline;
            Psi.WindowStyle = ProcessWindowStyle.Hidden;
            Psi.CreateNoWindow = true;
        }

        private void WorkerFunc()
        {
            string line;
            bool DeviceNotConnected = true;

            try
            {
                WorkingProcess = Process.Start(Psi);
            }
            catch
            {
                StartWait.Set();
                return;
            }

            Running = true;

            StartWait.Set();

            while (Consume)
            {
                line = WorkingProcess.StandardOutput.ReadLine();

                if (string.IsNullOrEmpty(line))
                    continue;

                if (line.StartsWith("-") || line.StartsWith("*"))
                    continue;

                if (DeviceNotConnected)
                {
                    DeviceNotConnected = false;

                    if (OnLineOutputReceive != null)
                        OnLineOutputReceive("DEVCON");
                }

                if (OnLineOutputReceive != null)
                    OnLineOutputReceive(line);
            }

            WorkerBlock.Set();
        }

        public void Start()
        {
            WorkerBlock.Reset();
            StartWait.Reset();

            ConsumeWorker = new Thread(new ThreadStart(WorkerFunc));
            ConsumeWorker.Start();

            StartWait.WaitOne(10 * 1000);
        }

        public void Kill()
        {
            //notify worker thread to finish
            Consume = false;

            //wait for worker thread
            if (!WorkerBlock.WaitOne(1000))
            {
                try
                {
                    ConsumeWorker.Abort();
                }
                catch { }
            }

            WorkingProcess.Kill();
        }

        public bool IsRunning
        {
            get { return Running; }
        }

        public string ExecutableFile
        {
            get
            {
                return Psi.FileName;
            }
            set
            {
                Psi.FileName = value;
            }
        }

        public event ConsoleLineOutputHandler OnLineOutputReceive;

    }
}
