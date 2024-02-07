namespace NekoForWindows
{
    partial class frmHome
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMyIp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NekoLog = new System.Windows.Forms.ListBox();
            this.CoreLog = new System.Windows.Forms.ListBox();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.btnRestart = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDisable = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEnable = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneShapes6 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShapes3 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStatus = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConfigName = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnRunningModeName = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneShapes2 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.lblRamUsage = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.siticoneShapes4 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "OS Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Uptime";
            // 
            // lblMyIp
            // 
            this.lblMyIp.AutoSize = true;
            this.lblMyIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblMyIp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyIp.ForeColor = System.Drawing.Color.White;
            this.lblMyIp.Location = new System.Drawing.Point(55, 84);
            this.lblMyIp.Name = "lblMyIp";
            this.lblMyIp.Size = new System.Drawing.Size(52, 16);
            this.lblMyIp.TabIndex = 46;
            this.lblMyIp.Text = "Devices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "RAM";
            // 
            // NekoLog
            // 
            this.NekoLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.NekoLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NekoLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NekoLog.ForeColor = System.Drawing.Color.White;
            this.NekoLog.FormattingEnabled = true;
            this.NekoLog.HorizontalScrollbar = true;
            this.NekoLog.ItemHeight = 18;
            this.NekoLog.Location = new System.Drawing.Point(12, 309);
            this.NekoLog.Name = "NekoLog";
            this.NekoLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NekoLog.Size = new System.Drawing.Size(558, 180);
            this.NekoLog.TabIndex = 43;
            // 
            // CoreLog
            // 
            this.CoreLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.CoreLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoreLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreLog.ForeColor = System.Drawing.Color.White;
            this.CoreLog.FormattingEnabled = true;
            this.CoreLog.HorizontalScrollbar = true;
            this.CoreLog.ItemHeight = 18;
            this.CoreLog.Location = new System.Drawing.Point(605, 260);
            this.CoreLog.Name = "CoreLog";
            this.CoreLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CoreLog.Size = new System.Drawing.Size(650, 234);
            this.CoreLog.TabIndex = 42;
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblUpload.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.ForeColor = System.Drawing.Color.White;
            this.lblUpload.Location = new System.Drawing.Point(351, 252);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(148, 22);
            this.lblUpload.TabIndex = 41;
            this.lblUpload.Text = "0.0 KB";
            this.lblUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDownload
            // 
            this.lblDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblDownload.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.ForeColor = System.Drawing.Color.White;
            this.lblDownload.Location = new System.Drawing.Point(94, 252);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(148, 22);
            this.lblDownload.TabIndex = 40;
            this.lblDownload.Text = "0.0 KB";
            this.lblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.Animated = true;
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnRestart.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnRestart.BorderThickness = 2;
            this.btnRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestart.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRestart.Location = new System.Drawing.Point(1075, 111);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(161, 33);
            this.btnRestart.TabIndex = 38;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Animated = true;
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnDisable.BorderColor = System.Drawing.Color.Red;
            this.btnDisable.BorderThickness = 2;
            this.btnDisable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnDisable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisable.ForeColor = System.Drawing.Color.Red;
            this.btnDisable.Location = new System.Drawing.Point(908, 111);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(161, 33);
            this.btnDisable.TabIndex = 37;
            this.btnDisable.Text = "DISABLE";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Animated = true;
            this.btnEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnEnable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnEnable.BorderThickness = 2;
            this.btnEnable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnEnable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(741, 111);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(161, 33);
            this.btnEnable.TabIndex = 36;
            this.btnEnable.Text = "ENABLE";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "U-Speed";
            // 
            // siticoneShapes6
            // 
            this.siticoneShapes6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes6.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes6.Location = new System.Drawing.Point(0, 218);
            this.siticoneShapes6.Name = "siticoneShapes6";
            this.siticoneShapes6.PolygonSkip = 2;
            this.siticoneShapes6.Rotate = 0F;
            this.siticoneShapes6.RoundedRadius = 15;
            this.siticoneShapes6.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes6.Size = new System.Drawing.Size(587, 70);
            this.siticoneShapes6.TabIndex = 34;
            this.siticoneShapes6.Text = "siticoneShapes6";
            this.siticoneShapes6.Zoom = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "D-Speed";
            // 
            // siticoneShapes3
            // 
            this.siticoneShapes3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes3.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes3.Location = new System.Drawing.Point(593, 46);
            this.siticoneShapes3.Name = "siticoneShapes3";
            this.siticoneShapes3.PolygonSkip = 2;
            this.siticoneShapes3.Rotate = 0F;
            this.siticoneShapes3.RoundedRadius = 15;
            this.siticoneShapes3.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes3.Size = new System.Drawing.Size(673, 166);
            this.siticoneShapes3.TabIndex = 32;
            this.siticoneShapes3.Text = "siticoneShapes3";
            this.siticoneShapes3.Zoom = 100;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(235, 49);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(116, 22);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Information";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(546, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 34);
            this.label8.TabIndex = 49;
            this.label8.Text = "Neko Home";
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
            this.siticoneShapes1.Size = new System.Drawing.Size(587, 166);
            this.siticoneShapes1.TabIndex = 60;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(628, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(900, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 22);
            this.label12.TabIndex = 64;
            this.label12.Text = "Neko";
            // 
            // btnStatus
            // 
            this.btnStatus.Animated = true;
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnStatus.BorderColor = System.Drawing.Color.Red;
            this.btnStatus.BorderThickness = 2;
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.Red;
            this.btnStatus.Location = new System.Drawing.Point(741, 80);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(125, 25);
            this.btnStatus.TabIndex = 65;
            this.btnStatus.Text = "DISABLE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(628, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 66;
            this.label13.Text = "Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(628, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 67;
            this.label14.Text = "Running Mode";
            // 
            // btnConfigName
            // 
            this.btnConfigName.Animated = true;
            this.btnConfigName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnConfigName.BorderColor = System.Drawing.Color.Yellow;
            this.btnConfigName.BorderThickness = 2;
            this.btnConfigName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfigName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfigName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfigName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfigName.FillColor = System.Drawing.Color.Yellow;
            this.btnConfigName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfigName.ForeColor = System.Drawing.Color.Black;
            this.btnConfigName.Location = new System.Drawing.Point(872, 80);
            this.btnConfigName.Name = "btnConfigName";
            this.btnConfigName.Size = new System.Drawing.Size(364, 25);
            this.btnConfigName.TabIndex = 68;
            // 
            // btnRunningModeName
            // 
            this.btnRunningModeName.Animated = true;
            this.btnRunningModeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnRunningModeName.BorderThickness = 2;
            this.btnRunningModeName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRunningModeName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRunningModeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRunningModeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRunningModeName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnRunningModeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRunningModeName.ForeColor = System.Drawing.Color.White;
            this.btnRunningModeName.Location = new System.Drawing.Point(741, 150);
            this.btnRunningModeName.Name = "btnRunningModeName";
            this.btnRunningModeName.Size = new System.Drawing.Size(495, 33);
            this.btnRunningModeName.TabIndex = 69;
            // 
            // siticoneShapes2
            // 
            this.siticoneShapes2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes2.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes2.Location = new System.Drawing.Point(593, 218);
            this.siticoneShapes2.Name = "siticoneShapes2";
            this.siticoneShapes2.PolygonSkip = 2;
            this.siticoneShapes2.Rotate = 0F;
            this.siticoneShapes2.RoundedRadius = 15;
            this.siticoneShapes2.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes2.Size = new System.Drawing.Size(673, 287);
            this.siticoneShapes2.TabIndex = 70;
            this.siticoneShapes2.Text = "siticoneShapes2";
            this.siticoneShapes2.Zoom = 100;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblOSVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVersion.ForeColor = System.Drawing.Color.White;
            this.lblOSVersion.Location = new System.Drawing.Point(381, 132);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(82, 16);
            this.lblOSVersion.TabIndex = 72;
            this.lblOSVersion.Text = "lblOSVersion";
            // 
            // lblRamUsage
            // 
            this.lblRamUsage.AutoSize = true;
            this.lblRamUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblRamUsage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamUsage.ForeColor = System.Drawing.Color.White;
            this.lblRamUsage.Location = new System.Drawing.Point(381, 108);
            this.lblRamUsage.Name = "lblRamUsage";
            this.lblRamUsage.Size = new System.Drawing.Size(84, 16);
            this.lblRamUsage.TabIndex = 73;
            this.lblRamUsage.Text = "lblRamUsage";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblDevice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.ForeColor = System.Drawing.Color.White;
            this.lblDevice.Location = new System.Drawing.Point(381, 84);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(58, 16);
            this.lblDevice.TabIndex = 74;
            this.lblDevice.Text = "lblDevice";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblUptime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptime.ForeColor = System.Drawing.Color.White;
            this.lblUptime.Location = new System.Drawing.Point(381, 156);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(61, 16);
            this.lblUptime.TabIndex = 75;
            this.lblUptime.Text = "lblUptime";
            // 
            // siticoneShapes4
            // 
            this.siticoneShapes4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes4.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes4.Location = new System.Drawing.Point(0, 294);
            this.siticoneShapes4.Name = "siticoneShapes4";
            this.siticoneShapes4.PolygonSkip = 2;
            this.siticoneShapes4.Rotate = 0F;
            this.siticoneShapes4.RoundedRadius = 15;
            this.siticoneShapes4.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes4.Size = new System.Drawing.Size(587, 211);
            this.siticoneShapes4.TabIndex = 76;
            this.siticoneShapes4.Text = "siticoneShapes4";
            this.siticoneShapes4.Zoom = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(880, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "Core Log";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1267, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NekoLog);
            this.Controls.Add(this.siticoneShapes4);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblRamUsage);
            this.Controls.Add(this.lblOSVersion);
            this.Controls.Add(this.btnRunningModeName);
            this.Controls.Add(this.btnConfigName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMyIp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CoreLog);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneShapes3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.siticoneShapes1);
            this.Controls.Add(this.siticoneShapes6);
            this.Controls.Add(this.siticoneShapes2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMyIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox NekoLog;
        private System.Windows.Forms.ListBox CoreLog;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblDownload;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRestart;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDisable;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEnable;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes6;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnConfigName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRunningModeName;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes2;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Label lblRamUsage;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblUptime;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes4;
        private System.Windows.Forms.Label label3;
    }
}