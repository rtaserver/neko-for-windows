﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekoForWindows
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        public void SetClientVersion(string version)
        {
            //btnClientVersion.Text = version;
        }

        public void SetCoreVersion(string version)
        {
            //btnCoreVersion.Text = version;
        }


        private void btnDBAI_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/vtV5QSq6D6");
        }

        private void btnIndoWrt_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/groups/indowrt");
        }

        private void btnNosignal_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/nosignals");
        }

        private void btnRtaserver_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rtaserver");
        }

        private void btnMetaCubeX_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MetaCubeX");
        }

        private void tmRainbow_Tick(object sender, EventArgs e)
        {
            Module.RaibowText(lblMe);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
        }
    }
}
