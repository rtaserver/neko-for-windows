using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace NekoForWindows
{
    public partial class frmHome : Form
    {
        private Process process;

        // Format the current time as a string in 24-hour format
        string CrtTime = DateTime.Now.ToString("HH:mm:ss");
        

        private DateTime startTime;
        public frmHome()
        {
            InitializeComponent();
            startTime = DateTime.Now;
        }

        public string STATUSNEKO()
        {
            return btnStatus.Text;
        }

        public void UpdateLogNeko(List<string> itemList)
        {
            NekoLog.Items.AddRange(itemList.ToArray());
        }

        public void UpdateLogCore(List<string> itemList)
        {
            CoreLog.Items.AddRange(itemList.ToArray());
        }


        PerformanceCounter ramUsageCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter maxRamCounter = new PerformanceCounter("Memory", "Committed Bytes");

        private long lastBytesReceived = 0;
        private long lastBytesSent = 0;
        private DateTime lastTime = DateTime.Now;
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            NekoLog.TopIndex = NekoLog.Items.Count - 1;
            CoreLog.TopIndex = CoreLog.Items.Count - 1;

            { // RAM USAGE
                float ramUsageMB = ramUsageCounter.NextValue();
                float totalRamMB = maxRamCounter.NextValue() / (1024 * 1024); // Convert bytes to megabytes
                lblRamUsage.Text = ($"{ramUsageMB} MB / {totalRamMB} MB");
            }

            {
                lblUptime.Text = GetSystemUptime();
            }


            {
                long currentUploadBytes = NetworkInterface.GetAllNetworkInterfaces().Select(n => n.GetIPv4Statistics().BytesSent).Sum();
                long currentDownloadBytes = NetworkInterface.GetAllNetworkInterfaces().Select(n => n.GetIPv4Statistics().BytesReceived).Sum();

                double speeddl = (currentDownloadBytes - lastBytesReceived) / (DateTime.Now - lastTime).TotalSeconds;
                double speedup = (currentUploadBytes - lastBytesSent) / (DateTime.Now - lastTime).TotalSeconds;

                lastBytesReceived = currentDownloadBytes;
                lastBytesSent = currentUploadBytes;
                lastTime = DateTime.Now;

                lblDownload.Text = $"{ConvertBytesToGB((long)speeddl)}";
                lblUpload.Text = $"{ConvertBytesToGB((long)speedup)}";
            }
        }

        private string ConvertBytesToGB(long bytes)
        {
            double mb = (double)bytes / (1024 * 1024);
            if (mb < 1)
            {
                return string.Format("{0} KB/s", bytes / 1024);
            }
            else if (mb < 1024)
            {
                return string.Format("{0:0.##} MB/s", mb);
            }
            else
            {
                double gb = mb / 1024;
                return string.Format("{0:0.##} GB/s", gb);
            }

        }
        private string GetSystemUptime()
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            return $"{elapsedTime.Hours} h {elapsedTime.Minutes} m {elapsedTime.Seconds} s";
        }


        public void LoadConfigurattion()
        {
            lblDevice.Text = Module.CheckArchitecture();
            lblOSVersion.Text = Module.CekOSWindows(); ;
            Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
            btnConfigName.Text = ReadWriteConfig.GetValueForKey(config, "SelectedConfig");
            btnRunningModeName.Text = ReadWriteConfig.GetValueForKey(config, "Enhanced");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadConfigurattion();
        }

        static string MyDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string NEKODIR = MyDir + @"\neko";
        static string MIHOMO = MyDir + @"\\neko\\core\\mihomo.exe";

        public string Status()
        {
            return btnStatus.Text;
        }

        public void StartNeko()
        {
            try
            {
                Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
                //CoreLog.Items.Clear();
                // SET HTTP PROXY
                //NekoLog.Items.Add($"[ {CrtTime} ] Set HTTP Proxy");
                //RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                //registry.SetValue("ProxyEnable", 1);
                //registry.SetValue("ProxyServer", "127.0.0.1:7890");
                //NekoLog.Items.Add($"[ {CrtTime} ] HTTP Proxy Sucess");

                // START CORE
                {
                    NekoLog.Items.Add($"[ {CrtTime} ] Start Core");
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = MIHOMO,
                        Arguments = $"-d {NEKODIR} -f {ReadWriteConfig.GetValueForKey(config, "SelectedConfig")}",
                        UseShellExecute = false, // Set to false to redirect input/output
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = false,
                        CreateNoWindow = true // Set to true to hide the command prompt window
                    };

                    // Create and start the process
                    process = new Process { StartInfo = startInfo };
                    process.OutputDataReceived += Process_OutputDataReceived; // Handle the output asynchronously
                    process.EnableRaisingEvents = true;
                    process.Exited += Process_Exited; // Handle process exit
                    process.Start();
                    process.BeginOutputReadLine();
                    NekoLog.Items.Add($"[ {CrtTime} ] Core Started");
                    btnStatus.FillColor = Color.FromArgb(25, 135, 84);
                    btnStatus.BorderColor = Color.FromArgb(25, 135, 84);
                    btnStatus.ForeColor = Color.White;
                    btnStatus.Text = "ENABLE";
                }
            }
            catch
            {

            }
        }

        public void StopNeko()
        {
            try
            {
                // KILL CORE
                string processName = "mihomo";
                Process[] processes = Process.GetProcessesByName(processName);

                if (processes.Length > 0)
                {
                    processes[0].Kill();
                    CoreLog.Items.Add($"Process {processName} has been terminated.");
                }

                // SET HTTP PROXY TO DEFAULT
                //NekoLog.Items.Add($"[ {CrtTime} ] Set HTTP Proxy To Default");
                //RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                //registry.SetValue("ProxyEnable", 0);
                //registry.SetValue("ProxyServer", "");

                NekoLog.Items.Add($"[ {CrtTime} ] Stop Neko Sucess");
                CoreLog.Items.Clear();
                btnStatus.FillColor = Color.FromArgb(231, 84, 128);
                btnStatus.BorderColor = Color.Red;
                btnStatus.ForeColor = Color.Red;
                btnStatus.Text = "DISABLE";
            }
            catch
            {
                MessageBox.Show("Stop Neko Failed");
            }
        }

        public void RestartNeko()
        {
            try
            {
                NekoLog.Items.Add($"[ {CrtTime} ] Restart Neko...");
                StopNeko();
                CoreLog.Items.Clear();
                Thread.Sleep(1000);
                NekoLog.Items.Add($"[ {CrtTime} ] Restart Beko Sucess");
                StartNeko();
            }
            catch
            {
                CoreLog.Items.Clear();
                StartNeko();
            }
        }
        private void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEnable.FillColor == Color.FromArgb(25, 135, 84))
                {
                    Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
                    if (File.Exists(ReadWriteConfig.GetValueForKey(config, "SelectedConfig")))
                    {
                        StartNeko();

                        btnEnable.FillColor = Color.FromArgb(231, 84, 128);
                        btnEnable.ForeColor = Color.FromArgb(25, 135, 84);
                        btnDisable.FillColor = Color.Red;
                        btnDisable.ForeColor = Color.White;
                        btnRestart.FillColor = Color.Goldenrod;
                        btnRestart.ForeColor = Color.White;

                    }
                    else
                    {
                        MessageBox.Show("Config Not Found..", "Neko For Windows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }         
                }
            }
            catch { }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDisable.FillColor == Color.Red)
                {
                    StopNeko();


                    btnDisable.FillColor = Color.FromArgb(231, 84, 128);
                    btnDisable.ForeColor = Color.Red;
                    btnEnable.FillColor = Color.FromArgb(25, 135, 84);
                    btnEnable.ForeColor = Color.White;
                    btnRestart.FillColor = Color.FromArgb(231, 84, 128);
                    btnRestart.ForeColor = Color.Goldenrod;
                }
            }
            catch { }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRestart.FillColor == Color.Goldenrod)
                {
                    RestartNeko();
                }
            }
            catch { }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                CoreLog.Invoke((Action)(() => CoreLog.Items.Add(e.Data)));
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            CoreLog.Invoke((Action)(() => CoreLog.Items.Add("Process has exited.")));
        }
    }
}
