namespace NekoForWindows
{
    partial class frmAbout
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
            this.components = new System.ComponentModel.Container();
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmRainbow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.siticoneShapes1.Size = new System.Drawing.Size(1267, 459);
            this.siticoneShapes1.TabIndex = 60;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(584, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 34);
            this.label11.TabIndex = 62;
            this.label11.Text = "About";
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMe.Location = new System.Drawing.Point(563, 134);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(140, 24);
            this.lblMe.TabIndex = 63;
            this.lblMe.Text = "RTA SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Build";
            // 
            // tmRainbow
            // 
            this.tmRainbow.Enabled = true;
            this.tmRainbow.Tick += new System.EventHandler(this.tmRainbow_Tick);
            // 
            // frmAbout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1267, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.siticoneShapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmRainbow;

        #endregion

        //private System.Windows.Forms.Label label11;
        //private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        //private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes2;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnDBAI;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnIndoWrt;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnNosignal;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnRtaserver;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnMetaCubeX;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label4;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnClientVersion;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnCoreVersion;
    }
}