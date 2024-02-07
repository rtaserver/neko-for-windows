using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Reflection;


namespace NekoForWindows
{
    public partial class frmMain : Form
    {
        

        private frmAbout FAbout;
        private frmConfig FConfig;
        private frmHome FHome;
        private frmSettings FSettings;

        public frmMain()
        {
            InitializeComponent();
            FAbout = new frmAbout();
            FConfig = new frmConfig();
            FHome = new frmHome();
            FSettings = new frmSettings();

            btnHome.PerformClick();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
            FAbout.SetClientVersion(ReadWriteConfig.GetValueForKey(config, "ClientVersion"));
            FAbout.SetCoreVersion(ReadWriteConfig.GetValueForKey(config, "CoreVersion"));
            FSettings.CheckForUpdate(true);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(FHome))
            { 
                FHome.TopLevel = false;
                FHome.FormBorderStyle = FormBorderStyle.None;
                FHome.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(FHome);
                FHome.Show();
                FHome.LoadConfigurattion();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (FHome.STATUSNEKO() == "ENABLE")
            {
                Process.Start("http://127.0.0.1:9090/ui/meta/");
            }
            else
            {
                MessageBox.Show("Neko Not Running :(", "Neko For Windows", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(FConfig))
            {
                FConfig.TopLevel = false;
                FConfig.FormBorderStyle = FormBorderStyle.None;
                FConfig.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(FConfig);
                FConfig.Show();
            }
        }

        public void GoSettings()
        {
            btnSettings.PerformClick();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(FSettings))
            {
                FSettings.TopLevel = false;
                FSettings.FormBorderStyle = FormBorderStyle.None;
                FSettings.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(FSettings);
                FSettings.Show();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(FAbout))
            {
                FAbout.TopLevel = false;
                FAbout.FormBorderStyle = FormBorderStyle.None;
                FAbout.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(FAbout);
                FAbout.Show();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
            Neko.NekoLogs.Add($"[ {Neko.CrtTime} ] Neko For Windows Started");
            Neko.NekoLogs.Add($"[ {Neko.CrtTime} ] Checking Default File..");
            Neko.CheckDefaultFile();
            FHome.UpdateLogNeko(Neko.NekoLogs);
            if (ReadWriteConfig.GetValueForKey(config, "FirstRun") == "true")
            {
                string targetFilePath = Path.Combine(Neko.MyDir + @"\neko", Path.GetFileName("config.zip"));
                Module.CopyResourceToFile("NekoForWindows.Config.config.zip", targetFilePath);
                Module.Unzip(targetFilePath, Neko.MyDir + @"\neko");
                ReadWriteConfig.ADDUPDATE(config, "FirstRun","false");
                ReadWriteConfig.WriteConfigFile(ReadWriteConfig.Temp, config);
                File.Delete(targetFilePath);
            }
        }

        private  void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (FHome.STATUSNEKO() == "ENABLE")
            {
                return;
            }
            else
            {
                try
                {
                    File.Delete($"{Application.ExecutablePath.Replace(Application.StartupPath + "\\", "")}.config");
                }
                catch
                {

                }

                Application.Exit();
            }

        }
    }
}
