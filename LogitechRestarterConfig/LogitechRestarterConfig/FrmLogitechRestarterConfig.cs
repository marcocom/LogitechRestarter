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

namespace LogitechRestarterConfig
{
    public partial class FrmLogitechRestarterConfig : Form
    {
        string SETTINGS_FILE = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LogitechRestarter\settings.jsn";
        RestarterSettings settings;
        string logitechRestarterName = "LogitechRestarter";
        string logitechSoftwareName = "";
        string logitechSoftwareVersion = "";
        int restarterPid = 0;
        Process restarter = new Process();

        
        public FrmLogitechRestarterConfig()
        {
            InitializeComponent();
        }

        private void chkStartOnLogin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryKey onStart = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                if (chkStartOnLogin.Checked)
                {
                    onStart.SetValue(logitechRestarterName, Application.StartupPath + "\\LogitechRestarter.exe");
                }
                else
                {
                    onStart.DeleteValue(logitechRestarterName, false);
                }
            }
            catch
            {
                MessageBox.Show("Couldn't modify startup registry key.\r\n Perhaps run me as administrator?");
                chkStartOnLogin.Checked = !chkStartOnLogin.Checked;
            }
        }

        private void FrmLogitechRestarterConfig_Load(object sender, EventArgs e)
        {
            settings = RestarterSettings.Load(SETTINGS_FILE);
            txtLogitechExe.Text = settings.LCoreExe;
            chkRegSearch.Checked = settings.RegSearch;
            checkStatus();

            RegistryKey onStart = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);
            if (onStart.GetValue(logitechRestarterName) != null)
            {
                chkStartOnLogin.Checked = true;
            }

            if (settings.RegSearch)
            {
                searchRegistry();
            }
        }

        private void searchRegistry()
        {
            bool haveLcoreLocation = false;
            if (Environment.Is64BitOperatingSystem)
            {
                RegistryKey hklm64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                haveLcoreLocation = getRegDetails(hklm64.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Logitech Gaming Software", false));
            }
            else
            {
                haveLcoreLocation = getRegDetails(Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Logitech Gaming Software", false));
            }
            if (!haveLcoreLocation)
            {
                MessageBox.Show("Couldn't find lcore location");
            }
        }

        private bool getRegDetails(RegistryKey lcoreRegKey)
        {
            bool haveLcoreLocation = false;
            try
            {
                if (lcoreRegKey != null)
                {
                    txtLogitechExe.Text = lcoreRegKey.GetValue("DisplayIcon").ToString();
                    txtInstalled.Text = lcoreRegKey.GetValue("DisplayName").ToString();
                    txtVersion.Text = lcoreRegKey.GetValue("DisplayVersion").ToString();
                    txtBitness.Text = "64 bit";
                    haveLcoreLocation = true;
                }
            }
            catch (Exception ex)
            {
                haveLcoreLocation = false;
                MessageBox.Show(ex.Message.ToString());
            }

            return haveLcoreLocation;
        }

        private void checkStatus()
        {
            Process[] candidates = Process.GetProcessesByName("LogitechRestarter");
            switch (candidates.Length)
            {
                case 1:
                    restarter = candidates[0];
                    restarterPid = restarter.Id;
                    lblRestarterRunning.ForeColor = Color.Green;
                    lblRestarterPid.Text = restarterPid.ToString();
                    btnStartStop.Text = "Stop Restarter";
                    break;
                case 0:
                    restarterPid = 0;
                    lblRestarterRunning.ForeColor = Color.Red;
                    lblRestarterPid.Text = "";
                    btnStartStop.Text = "Start Restarter";
                    break;
                default:
                    //Multiple processes running. Kill 'em all?
                    break;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (restarterPid != 0)
            {
                restarter.Kill();
                restarterPid = 0;
            }
            else
            {
                restarter.StartInfo.FileName = Environment.CurrentDirectory + @"\LogitechRestarter.exe";
                restarter.Start();
            }
        }

        private void checkTimer_Tick(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void btnPickLcore_Click(object sender, EventArgs e)
        {
            LcoreFileDialog.ShowDialog();
        }

        private void txtLogitechExe_MouseClick(object sender, MouseEventArgs e)
        {
            LcoreFileDialog.ShowDialog();
        }

        private void LcoreFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtLogitechExe.Text = LcoreFileDialog.FileName;
        }

        private void txtLogitechExe_TextChanged(object sender, EventArgs e)
        {
            settings.LCoreExe = txtLogitechExe.Text;
            settings.Save(SETTINGS_FILE);
        }

        private void chkRegSearch_CheckedChanged(object sender, EventArgs e)
        {
            settings.RegSearch = chkRegSearch.Checked;
            settings.Save(SETTINGS_FILE);
            if (chkRegSearch.Checked)
            {
                searchRegistry();
            }
        }
    }
}
