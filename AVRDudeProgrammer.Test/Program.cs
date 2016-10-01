using System;
using System.Windows.Forms;

namespace AtmelStudio.AVRDude.Wrapper.Test
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new AVRDudeUI());
        }
    }
}