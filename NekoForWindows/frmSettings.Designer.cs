namespace NekoForWindows
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.btnCheckClient = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCheckCore = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PGBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(568, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 34);
            this.label8.TabIndex = 50;
            this.label8.Text = "Settings";
            // 
            // siticoneShapes1
            // 
            this.siticoneShapes1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes1.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes1.Location = new System.Drawing.Point(0, 46);
            this.siticoneShapes1.Name = "siticoneShapes1";
            this.siticoneShapes1.PolygonSkip = 2;
            this.siticoneShapes1.Rotate = 0F;
            this.siticoneShapes1.RoundedRadius = 15;
            this.siticoneShapes1.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes1.Size = new System.Drawing.Size(1267, 114);
            this.siticoneShapes1.TabIndex = 61;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 100;
            // 
            // btnCheckClient
            // 
            this.btnCheckClient.Animated = true;
            this.btnCheckClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnCheckClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnCheckClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckClient.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCheckClient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckClient.ForeColor = System.Drawing.Color.White;
            this.btnCheckClient.Location = new System.Drawing.Point(143, 68);
            this.btnCheckClient.Name = "btnCheckClient";
            this.btnCheckClient.Size = new System.Drawing.Size(390, 44);
            this.btnCheckClient.TabIndex = 69;
            this.btnCheckClient.Text = "Check Client Update";
            this.btnCheckClient.Click += new System.EventHandler(this.btnCheckClient_Click);
            // 
            // btnCheckCore
            // 
            this.btnCheckCore.Animated = true;
            this.btnCheckCore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnCheckCore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnCheckCore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckCore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckCore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckCore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckCore.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCheckCore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCore.ForeColor = System.Drawing.Color.White;
            this.btnCheckCore.Location = new System.Drawing.Point(733, 68);
            this.btnCheckCore.Name = "btnCheckCore";
            this.btnCheckCore.Size = new System.Drawing.Size(390, 44);
            this.btnCheckCore.TabIndex = 70;
            this.btnCheckCore.Text = "Check Core Update";
            this.btnCheckCore.Click += new System.EventHandler(this.btnCheckCore_Click);
            // 
            // PGBar
            // 
            this.PGBar.Location = new System.Drawing.Point(143, 118);
            this.PGBar.Name = "PGBar";
            this.PGBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.PGBar.ProgressColor2 = System.Drawing.Color.IndianRed;
            this.PGBar.ShowText = true;
            this.PGBar.Size = new System.Drawing.Size(980, 25);
            this.PGBar.TabIndex = 71;
            this.PGBar.TextMode = Siticone.Desktop.UI.WinForms.Enums.ProgressBarTextMode.Custom;
            this.PGBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PGBar.Value = 50;
            this.PGBar.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1267, 517);
            this.Controls.Add(this.PGBar);
            this.Controls.Add(this.btnCheckCore);
            this.Controls.Add(this.btnCheckClient);
            this.Controls.Add(this.siticoneShapes1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckClient;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCheckCore;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar PGBar;
    }
}