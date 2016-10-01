using System;
using System.Diagnostics;
using System.Text;

namespace AtmelStudio.AVRDude.Wrapper
{
    public sealed class AVRDudeProcessWrapper
    {
        public event EventHandler<AVRDudeOutputMessage> MessageReceived;
             
        private readonly AVRDudeProcessInfo info;
        public AVRDudeProcessWrapper(AVRDudeProcessInfo info)
        {
            this.info = info;
        }

        internal void Program(string file)
        {
            var process = GetProcess();
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            var result = process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            if (result)
            {
                process.WaitForExit();
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Fire(new AVRDudeOutputMessage(e.Data, false));
        }

        private void Fire(AVRDudeOutputMessage msg)
        {
            MessageReceived?.Invoke(null, msg);
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Fire(new AVRDudeOutputMessage(e.Data, true));
        }

        private Process GetProcess()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(info.FullPath, info.Args)
                {
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    StandardOutputEncoding = Encoding.UTF8,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            return process;
        }
    }
}