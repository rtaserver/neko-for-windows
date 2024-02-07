using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NekoForWindows
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Neko.MyDir + @"\neko\config");
        }

        private void YamlConfig()
        {
            try
            {
                string directoryPath = Neko.MyDir + @"\neko\config";

                // Get all files in the directory with a .yaml or .yml extension
                var yamlFiles = Directory.GetFiles(directoryPath, "*.yaml")
                                          .Union(Directory.GetFiles(directoryPath, "*.yml"));

                // Bind the list of full paths to the ComboBox
                cbConfig.DataSource = yamlFiles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add an event handler for ComboBox selection change if needed
        private void cbConfig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tmrList_Tick(object sender, EventArgs e)
        {

        }

        private void ReadConfigYaml()
        {
            try
            {
                Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
                txtPort.Text = ReadWriteConfig.GetValueForKey(config, "Port");
                txtRedir.Text = ReadWriteConfig.GetValueForKey(config, "Redir");
                txtSocks.Text = ReadWriteConfig.GetValueForKey(config, "Socks");
                txtMixed.Text = ReadWriteConfig.GetValueForKey(config, "Mixed");
                txtTproxy.Text = ReadWriteConfig.GetValueForKey(config, "TProxy");
                txtMode.Text = ReadWriteConfig.GetValueForKey(config, "Mode");
                txtEnhanced.Text = ReadWriteConfig.GetValueForKey(config, "Enhanced");
                txtSecret.Text = ReadWriteConfig.GetValueForKey(config, "Secret");
                txtController.Text = ReadWriteConfig.GetValueForKey(config, "Controller");
                cbConfig.SelectedItem = ReadWriteConfig.GetValueForKey(config, "SelectedConfig");
            }
            catch { }
            
        }

        
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbConfig.SelectedItem != null)
                {
                    Module.ReadConfig(cbConfig.SelectedItem.ToString());
                    txtPort.Text = Module.port;
                    txtRedir.Text = Module.redirPort;
                    txtSocks.Text = Module.socksPort;
                    txtMixed.Text = Module.mixedPort;
                    txtTproxy.Text = Module.tproxyPort;
                    txtMode.Text = Module.mode;
                    txtEnhanced.Text = Module.enhancedMode;
                    txtSecret.Text = Module.secret;
                    txtController.Text = Module.externalController;
                }
                
            }
            catch { }
            

        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                YamlConfig();
                ReadConfigYaml();
            }
            catch
            {

            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbConfig.SelectedItem != null)
                {
                    Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
                    ReadWriteConfig.ADDUPDATE(config, "Port", txtPort.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Redir", txtRedir.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Socks", txtSocks.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Mixed", txtMixed.Text);
                    ReadWriteConfig.ADDUPDATE(config, "TProxy", txtTproxy.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Mode", txtMode.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Enhanced", txtEnhanced.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Secret", txtSecret.Text);
                    ReadWriteConfig.ADDUPDATE(config, "Controller", txtController.Text);
                    ReadWriteConfig.ADDUPDATE(config, "SelectedConfig", cbConfig.SelectedItem.ToString());
                    ReadWriteConfig.WriteConfigFile(ReadWriteConfig.Temp, config);
                    frmHome home = new frmHome();
                    home.LoadConfigurattion();
                }
                    
            }
            catch { }

            
        }

        private void cbConfig_Click(object sender, EventArgs e)
        {
            YamlConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpConfig_Click(object sender, EventArgs e)
        {
            if (SHelp.Visible == true)
            {
                SHelp.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                btnHelpConfig.Text = "CLICK ME IF YOUR CONFIG NOT CONECTED TO INTERNET";
            }
            else
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                SHelp.Visible=true;
                btnHelpConfig.Text = "Close Me";
            }
        }
    }
}
