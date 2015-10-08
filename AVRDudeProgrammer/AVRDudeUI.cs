using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmelStudio.AVRDude.Wrapper
{
    public partial class AVRDudeUI : Form
    {
        public AVRDudeUI()
        {
            InitializeComponent();
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var service = GetWebBrowsingService();
            IVsWindowFrame frame = null;
            service.Navigate("http://www.nongnu.org/avrdude/user-manual/avrdude_4.html#Option-Descriptions", 8, out frame);
            frame.Show();
        }

        private void btnChooseExecutable_Click(object sender, EventArgs e)
        {
            var path = GetPath("Executable|*.exe", "Select avrdude.exe", GuessAVRDudePath());
            txtAVRDudePath.Text = path;
        }

        private void btnSelectBinary_Click(object sender, EventArgs e)
        {
            var path = GetPath("Intel Hex File|*.hex", "Select HEX file to burn", GuessAVRDudePath());
            txtAVRDudePath.Text = path;
        }

        private void btnChooseConf_Click(object sender, EventArgs e)
        {
            var path = GetPath("AVRDude Configuration File|*.conf", "Select avrdude conf file", GuessAVRDudePath());
            txtAVRDudePath.Text = path;
        }

        private void AVRDudeUI_Load(object sender, EventArgs e)
        {
            outputWindow.Visible = false;
            radioConfFile.Checked = false;
            radioCmdLine.Checked = true;
            LoadInitialValues();
        }

        private void LoadInitialValues()
        {
            txtAVRDudePath.Text = GuessAVRDudePath();
            txtProgramPath.Text = GuessBinPath();
            txtConfFilePath.Text = GuessAVRDudeConf();
            txtCommandLine.Text = string.Format("-p {0}", GetDudeDevice());
        }

        private string GuessBinPath()
        {
            var path = GetProjectOutputPath();
            return Directory.Exists(path)
            ? Directory.EnumerateFiles(path, "*.hex").FirstOrDefault()
            : string.Empty;
        }

        IVsWebBrowsingService GetWebBrowsingService()
        {
            var service = Package.GetGlobalService(typeof(SVsWebBrowsingService)) as IVsWebBrowsingService;
            return service;
        }

        private string GetDudeDevice()
        {
            var dudeDevice = DeviceReference.Get(GetDeviceNameInProject());
            return dudeDevice;
        }

        private string GetPath(string filter, string title, string initialDir)
        {
            var fileDialog = GetFileDialog(filter, title, initialDir);
            return GetPathFromUser(fileDialog);
        }

        private string GetPathFromUser(OpenFileDialog fileDialog)
        {
            var result = fileDialog.ShowDialog();
            var ok = DialogResult.OK;
            return result == ok ? fileDialog.FileName : string.Empty;
        }

        private OpenFileDialog GetFileDialog(string filter, string title, string initialDir)
        {
            return new OpenFileDialog()
            {
                Title = title,
                InitialDirectory = initialDir,
                Filter = filter
            };
        }

        string GetProjectOutputPath()
        {
            var result = Path.Combine(GetProjectProperty("FullPath"), GetConfiguration());
            return result;
        }


        string GetDeviceNameInProject()
        {
            var result = GetProjectProperty("DeviceName");
            return result;
        }

        string GetProjectProperty(string propName)
        {
            var result = string.Empty;
            try
            {
                result = GetProject()
                    .Properties
                    .Item(propName)
                    .Value.ToString();
            }
            catch (Exception) { }
            return result;
        }

        string GetConfiguration()
        {
            try
            {
                return GetProject().
                    ConfigurationManager
                    .ActiveConfiguration
                    .ConfigurationName;
            }
            catch (Exception) { }
            return string.Empty;
        }

        EnvDTE.Project GetProject()
        {
            return (Package.GetGlobalService(typeof(SDTE)) as DTE)
                    .Solution
                    .Projects
                    .Item(1);
        }


        string GuessAVRDudePath()
        {
            return Directory.Exists(DudeDirectory())
                ? Path.Combine(DudeDirectory(), "avrdude.exe")
                : string.Empty;
        }

        string GuessAVRDudeConf()
        {
            return Directory.Exists(DudeDirectory())
                ? Path.Combine(DudeDirectory(), "avrdude.conf")
                : string.Empty;
        }

        string DudeDirectory()
        {
            var assFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var avrDudeDir = Path.Combine(assFolder, "avrdude", "6.1");
            return avrDudeDir;
        }

        IVsOutputWindowPane outputPane;
        private void btnProgram_Click(object sender, EventArgs e)
        {
            var info = GetProcessInfo();
            AVRDudeProcessWrapper programmer = new AVRDudeProcessWrapper(info);
            outputPane = CreateOrGetOutputWindowPane();
            outputPane.Activate();
            programmer.MessageReceived += Programmer_MessageReceived;
            programmer.Program(txtProgramPath.Text);
        }


        private void Programmer_MessageReceived(object sender, AVRDudeOutputMessage e)
        {
            if (string.IsNullOrEmpty(e.Message))
                return;
            outputPane.OutputStringThreadSafe(e.Message);
            outputPane.OutputStringThreadSafe(Environment.NewLine);
        }

        private Guid paneGuid = new Guid("{8AA85C70-6FD0-465F-9AD3-6B1D75C1F7C6}");
        private IVsOutputWindowPane CreateOrGetOutputWindowPane()
        {
            var outputWindow = Package.GetGlobalService(typeof(SVsOutputWindow)) as IVsOutputWindow;
            IVsOutputWindowPane ppPane;
            outputWindow.GetPane(ref paneGuid, out ppPane);
            if (ppPane == null)
                outputWindow.CreatePane(ref paneGuid, "AVR Dude", 0, 0);

            outputWindow.GetPane(ref paneGuid, out ppPane);
            return ppPane;
        }

        private AVRDudeProcessInfo GetProcessInfo()
        {
            return new AVRDudeProcessInfo(
                txtAVRDudePath.Text,
                txtCommandLine.Text,
                radioCmdLine.Checked ? ArgumentMode.CmdLine : ArgumentMode.ConfFile,
                txtConfFilePath.Text
                );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

