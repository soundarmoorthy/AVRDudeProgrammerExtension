using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmelStudio.AVRDude.Wrapper
{
    public sealed class AVRDudeProcessWrapper
    {
        public event EventHandler<AVRDudeOutputMessage> MessageReceived;
             
        AVRDudeProcessInfo info;
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

        void Fire(AVRDudeOutputMessage msg)
        {
            if (MessageReceived != null)
                MessageReceived(null, msg);
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Fire(new AVRDudeOutputMessage(e.Data, true));
        }

        private Process GetProcess()
        {
            var process = new Process();
            var argument = GetArgument();
            process.StartInfo = new ProcessStartInfo(info.FullPath, info.Args);
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return process;
        }

        private string GetArgument()
        {
            if (info.Mode == ArgumentMode.ConfFile)
                return "-C " + info.ConfFile;
            else
                return info.Args;
            
        }
    }
}