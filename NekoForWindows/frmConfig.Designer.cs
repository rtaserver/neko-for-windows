namespace NekoForWindows
{
    partial class frmConfig
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
            this.cbConfig = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnApply = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnBrowse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTproxy = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtRedir = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMixed = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtSecret = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtSocks = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtEnhanced = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtPort = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtController = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.siticoneShapes1 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.siticoneShapes2 = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            this.label11 = new System.Windows.Forms.Label();
            this.tmrList = new System.Windows.Forms.Timer(this.components);
            this.btnHelpConfig = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnRestore = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // cbConfig
            // 
            this.cbConfig.BackColor = System.Drawing.Color.Transparent;
            this.cbConfig.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfig.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbConfig.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbConfig.ItemHeight = 30;
            this.cbConfig.Items.AddRange(new object[] {
            "Config"});
            this.cbConfig.Location = new System.Drawing.Point(159, 108);
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(823, 36);
            this.cbConfig.TabIndex = 32;
            this.cbConfig.SelectedIndexChanged += new System.EventHandler(this.cbConfig_SelectedIndexChanged);
            this.cbConfig.Click += new System.EventHandler(this.cbConfig_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.lblInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(600, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(66, 22);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Config Information";
            // 
            // btnChange
            // 
            this.btnChange.Animated = true;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnChange.BorderThickness = 2;
            this.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Location = new System.Drawing.Point(159, 150);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(473, 43);
            this.btnChange.TabIndex = 37;
            this.btnChange.Text = "CHANGE CONFIG";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnApply
            // 
            this.btnApply.Animated = true;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnApply.BorderThickness = 2;
            this.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(634, 150);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(473, 43);
            this.btnApply.TabIndex = 38;
            this.btnApply.Text = "APPLY CONFIG";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Animated = true;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnBrowse.BorderThickness = 2;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(988, 108);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 36);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "BROWSE FOLDER";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtTproxy
            // 
            this.txtTproxy.BorderColor = System.Drawing.Color.Transparent;
            this.txtTproxy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTproxy.DefaultText = "";
            this.txtTproxy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTproxy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTproxy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTproxy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTproxy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtTproxy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTproxy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTproxy.ForeColor = System.Drawing.Color.White;
            this.txtTproxy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTproxy.Location = new System.Drawing.Point(480, 367);
            this.txtTproxy.Name = "txtTproxy";
            this.txtTproxy.PasswordChar = '\0';
            this.txtTproxy.PlaceholderText = "";
            this.txtTproxy.ReadOnly = true;
            this.txtTproxy.SelectedText = "";
            this.txtTproxy.Size = new System.Drawing.Size(303, 34);
            this.txtTproxy.TabIndex = 40;
            this.txtTproxy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRedir
            // 
            this.txtRedir.BorderColor = System.Drawing.Color.Transparent;
            this.txtRedir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRedir.DefaultText = "";
            this.txtRedir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRedir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRedir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRedir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRedir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtRedir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRedir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedir.ForeColor = System.Drawing.Color.White;
            this.txtRedir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRedir.Location = new System.Drawing.Point(480, 300);
            this.txtRedir.Name = "txtRedir";
            this.txtRedir.PasswordChar = '\0';
            this.txtRedir.PlaceholderText = "";
            this.txtRedir.ReadOnly = true;
            this.txtRedir.SelectedText = "";
            this.txtRedir.Size = new System.Drawing.Size(303, 34);
            this.txtRedir.TabIndex = 41;
            this.txtRedir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMixed
            // 
            this.txtMixed.BorderColor = System.Drawing.Color.Transparent;
            this.txtMixed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMixed.DefaultText = "";
            this.txtMixed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMixed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMixed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMixed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMixed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtMixed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMixed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMixed.ForeColor = System.Drawing.Color.White;
            this.txtMixed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMixed.Location = new System.Drawing.Point(171, 367);
            this.txtMixed.Name = "txtMixed";
            this.txtMixed.PasswordChar = '\0';
            this.txtMixed.PlaceholderText = "";
            this.txtMixed.ReadOnly = true;
            this.txtMixed.SelectedText = "";
            this.txtMixed.Size = new System.Drawing.Size(303, 34);
            this.txtMixed.TabIndex = 42;
            this.txtMixed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecret
            // 
            this.txtSecret.BorderColor = System.Drawing.Color.Transparent;
            this.txtSecret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecret.DefaultText = "";
            this.txtSecret.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecret.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecret.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecret.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecret.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtSecret.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecret.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecret.ForeColor = System.Drawing.Color.White;
            this.txtSecret.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecret.Location = new System.Drawing.Point(480, 428);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.PasswordChar = '\0';
            this.txtSecret.PlaceholderText = "";
            this.txtSecret.ReadOnly = true;
            this.txtSecret.SelectedText = "";
            this.txtSecret.Size = new System.Drawing.Size(303, 34);
            this.txtSecret.TabIndex = 43;
            this.txtSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSocks
            // 
            this.txtSocks.BorderColor = System.Drawing.Color.Transparent;
            this.txtSocks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSocks.DefaultText = "";
            this.txtSocks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSocks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSocks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtSocks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSocks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocks.ForeColor = System.Drawing.Color.White;
            this.txtSocks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSocks.Location = new System.Drawing.Point(789, 300);
            this.txtSocks.Name = "txtSocks";
            this.txtSocks.PasswordChar = '\0';
            this.txtSocks.PlaceholderText = "";
            this.txtSocks.ReadOnly = true;
            this.txtSocks.SelectedText = "";
            this.txtSocks.Size = new System.Drawing.Size(303, 34);
            this.txtSocks.TabIndex = 44;
            this.txtSocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnhanced
            // 
            this.txtEnhanced.BorderColor = System.Drawing.Color.Transparent;
            this.txtEnhanced.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnhanced.DefaultText = "";
            this.txtEnhanced.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnhanced.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnhanced.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnhanced.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnhanced.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtEnhanced.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnhanced.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnhanced.ForeColor = System.Drawing.Color.White;
            this.txtEnhanced.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnhanced.Location = new System.Drawing.Point(171, 428);
            this.txtEnhanced.Name = "txtEnhanced";
            this.txtEnhanced.PasswordChar = '\0';
            this.txtEnhanced.PlaceholderText = "";
            this.txtEnhanced.ReadOnly = true;
            this.txtEnhanced.SelectedText = "";
            this.txtEnhanced.Size = new System.Drawing.Size(303, 34);
            this.txtEnhanced.TabIndex = 45;
            this.txtEnhanced.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.BorderColor = System.Drawing.Color.Transparent;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultText = "";
            this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.Location = new System.Drawing.Point(171, 300);
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PlaceholderText = "";
            this.txtPort.ReadOnly = true;
            this.txtPort.SelectedText = "";
            this.txtPort.Size = new System.Drawing.Size(303, 34);
            this.txtPort.TabIndex = 46;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMode
            // 
            this.txtMode.BorderColor = System.Drawing.Color.Transparent;
            this.txtMode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMode.DefaultText = "";
            this.txtMode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtMode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.ForeColor = System.Drawing.Color.White;
            this.txtMode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMode.Location = new System.Drawing.Point(789, 367);
            this.txtMode.Name = "txtMode";
            this.txtMode.PasswordChar = '\0';
            this.txtMode.PlaceholderText = "";
            this.txtMode.ReadOnly = true;
            this.txtMode.SelectedText = "";
            this.txtMode.Size = new System.Drawing.Size(306, 34);
            this.txtMode.TabIndex = 47;
            this.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(297, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "MIXED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "ENHANCED";
            // 
            // txtController
            // 
            this.txtController.BorderColor = System.Drawing.Color.Transparent;
            this.txtController.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtController.DefaultText = "";
            this.txtController.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtController.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtController.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtController.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtController.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.txtController.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtController.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtController.ForeColor = System.Drawing.Color.White;
            this.txtController.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtController.Location = new System.Drawing.Point(789, 428);
            this.txtController.Name = "txtController";
            this.txtController.PasswordChar = '\0';
            this.txtController.PlaceholderText = "";
            this.txtController.ReadOnly = true;
            this.txtController.SelectedText = "";
            this.txtController.Size = new System.Drawing.Size(306, 34);
            this.txtController.TabIndex = 52;
            this.txtController.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(603, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "REDIR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(908, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "SOCKS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "TPROXY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(914, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "MODE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(595, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "SECRET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(885, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "CONTROLLER";
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
            this.siticoneShapes1.Size = new System.Drawing.Size(1267, 166);
            this.siticoneShapes1.TabIndex = 59;
            this.siticoneShapes1.Text = "siticoneShapes1";
            this.siticoneShapes1.Zoom = 100;
            // 
            // siticoneShapes2
            // 
            this.siticoneShapes2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShapes2.BorderColor = System.Drawing.Color.White;
            this.siticoneShapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.siticoneShapes2.Location = new System.Drawing.Point(0, 218);
            this.siticoneShapes2.Name = "siticoneShapes2";
            this.siticoneShapes2.PolygonSkip = 2;
            this.siticoneShapes2.Rotate = 0F;
            this.siticoneShapes2.RoundedRadius = 15;
            this.siticoneShapes2.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            this.siticoneShapes2.Size = new System.Drawing.Size(1267, 287);
            this.siticoneShapes2.TabIndex = 60;
            this.siticoneShapes2.Text = "siticoneShapes2";
            this.siticoneShapes2.Zoom = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.label11.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(579, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 34);
            this.label11.TabIndex = 61;
            this.label11.Text = "Config";
            // 
            // tmrList
            // 
            this.tmrList.Enabled = true;
            this.tmrList.Tick += new System.EventHandler(this.tmrList_Tick);
            // 
            // btnHelpConfig
            // 
            this.btnHelpConfig.Animated = true;
            this.btnHelpConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnHelpConfig.BorderColor = System.Drawing.Color.Red;
            this.btnHelpConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelpConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelpConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelpConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelpConfig.FillColor = System.Drawing.Color.Crimson;
            this.btnHelpConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHelpConfig.ForeColor = System.Drawing.Color.White;
            this.btnHelpConfig.Location = new System.Drawing.Point(171, 468);
            this.btnHelpConfig.Name = "btnHelpConfig";
            this.btnHelpConfig.Size = new System.Drawing.Size(461, 26);
            this.btnHelpConfig.TabIndex = 62;
            this.btnHelpConfig.Text = "CLICK ME IF YOUR CONFIG NOT CONECTED TO INTERNET";
            // 
            // btnRestore
            // 
            this.btnRestore.Animated = true;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnRestore.BorderColor = System.Drawing.Color.Red;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.Crimson;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(634, 468);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(461, 26);
            this.btnRestore.TabIndex = 63;
            this.btnRestore.Text = "RESTORE TO DEFAULT CONFIG";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1267, 517);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnHelpConfig);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtController);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtEnhanced);
            this.Controls.Add(this.txtSocks);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtMixed);
            this.Controls.Add(this.txtRedir);
            this.Controls.Add(this.txtTproxy);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbConfig);
            this.Controls.Add(this.siticoneShapes1);
            this.Controls.Add(this.siticoneShapes2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbConfig;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnChange;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnApply;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBrowse;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTproxy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtRedir;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMixed;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSecret;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSocks;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtEnhanced;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPort;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes1;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes siticoneShapes2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tmrList;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHelpConfig;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRestore;
    }
}