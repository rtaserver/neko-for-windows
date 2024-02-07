
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NekoForWindows
{
    public sealed partial class UpdateForm : Form
    {
        public UpdateForm(string message, bool newUpdate,string to, string changelog, string latestVersion)
        {
            Dictionary<string, string> config = ReadWriteConfig.ReadConfigFile(ReadWriteConfig.Temp);
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //OptionsHelper.ApplyTheme(this);

            txtMessage.Text = message;

            if (newUpdate)
            {
                this.Size = new Size(600, 545);
               // btnOK.Text = OptionsHelper.TranslationList["btnYes"].ToString();
               // btnNo.Text = OptionsHelper.TranslationList["btnNo"].ToString();
                btnNo.Visible = true;
               // txtChanges.Text = OptionsHelper.TranslationList["btnChangelog"].ToString();
               if (to == "client")
                {
                    txtVersions.Text = $"{ReadWriteConfig.GetValueForKey(config,"ClientVersion")} → {latestVersion}";
                }
               if (to == "core")
                {
                    txtVersions.Text = $"{ReadWriteConfig.GetValueForKey(config, "CoreVersion")} → {latestVersion}";
                }
                txtVersions.Visible = true;

                btnOK.DialogResult = DialogResult.Yes;
                btnNo.DialogResult = DialogResult.No;

                txtInfo.Text = changelog;
                txtInfo.Visible = true;
                txtChanges.Visible = true;
            }
            else
            {
                this.Size = new Size(600, 188);
               // btnOK.Text = OptionsHelper.TranslationList["btnAbout"].ToString();
                btnNo.Visible = false;
                txtVersions.Visible = false;

                btnOK.DialogResult = DialogResult.OK;

                txtInfo.Visible = false;
                txtChanges.Visible = false;
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
