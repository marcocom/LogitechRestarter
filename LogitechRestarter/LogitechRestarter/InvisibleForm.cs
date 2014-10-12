using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace LogitechRestarter
{
    public partial class InvisibleForm : Form
    {
        string SETTINGS_FILE = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LogitechRestarter\settings.jsn";
        RestarterSettings settings;
        string LCoreExe = @"C:\Program Files\Logitech Gaming Software\LCore.exe";
        string LCoreProc = "LCore";

        public InvisibleForm()
        {
            InitializeComponent();
        }

        private void InvisibleForm_Load(object sender, EventArgs e)
        {
            SystemEvents.PowerModeChanged += OnPowerChange;
            settings = RestarterSettings.Load(SETTINGS_FILE);
            LCoreExe = settings.LCoreExe;
            LCoreProc = Path.GetFileNameWithoutExtension(LCoreExe);
            this.Hide();
        }

        private void OnPowerChange(object s, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    Process logitech = new Process();
                    logitech.StartInfo.FileName = LCoreExe;
                    logitech.StartInfo.Arguments = "/minimized";
                    logitech.Start();
                    break;
                case PowerModes.Suspend:
                    foreach (var process in Process.GetProcessesByName(LCoreProc))
                    {
                        process.Kill();
                    }
                    break;
            }
        }
    }
}
