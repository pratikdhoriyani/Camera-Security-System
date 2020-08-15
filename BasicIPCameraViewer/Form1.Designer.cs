namespace VideoCameraViewer
{
    partial class Form1
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
      
        #endregion


         private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.CameraTypeCombo = new System.Windows.Forms.ComboBox();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.VideoInfoText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AudioInfoText = new System.Windows.Forms.TextBox();
            this.StreamCombo = new System.Windows.Forms.ComboBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SetSharpnessButt = new System.Windows.Forms.Button();
            this.SharpnessText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SetBackLightButt = new System.Windows.Forms.Button();
            this.BackLightText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TrackBarSaturation = new System.Windows.Forms.TrackBar();
            this.Labelbrightness = new System.Windows.Forms.Label();
            this.TrackBarContrast = new System.Windows.Forms.TrackBar();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.verticalFlipButt = new System.Windows.Forms.Button();
            this.horizFlipButt = new System.Windows.Forms.Button();
            this.LabelSaturation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelContrast = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.CameraDetailsBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.DetailsText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.CameraDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.CameraTypeCombo);
            this.groupBox9.Location = new System.Drawing.Point(270, 42);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(158, 66);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Camera Type";
            // 
            // CameraTypeCombo
            // 
            this.CameraTypeCombo.Items.AddRange(new object[] {
            "USB camera",
            "RTSP camera",
            "ONVIF camera"});
            this.CameraTypeCombo.Location = new System.Drawing.Point(19, 29);
            this.CameraTypeCombo.Name = "CameraTypeCombo";
            this.CameraTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.CameraTypeCombo.TabIndex = 0;
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Disconnect.ForeColor = System.Drawing.Color.Black;
            this.button_Disconnect.Location = new System.Drawing.Point(354, 12);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(79, 23);
            this.button_Disconnect.TabIndex = 7;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(269, 12);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(79, 23);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(94, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(94, 42);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(170, 20);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(94, 13);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(170, 20);
            this.textBoxHost.TabIndex = 1;
            this.textBoxHost.Text = "192.168.115.198:8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera URL:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logListBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eventlog";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(6, 19);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(438, 108);
            this.logListBox.TabIndex = 0;
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(12, 134);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(450, 360);
            this.CameraBox.TabIndex = 3;
            this.CameraBox.TabStop = false;
            this.CameraBox.Text = "Live camera ";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.settingsTab);
            this.TabControl.Location = new System.Drawing.Point(468, 134);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(455, 360);
            this.TabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.StreamCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 334);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Streams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Available";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(6, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 295);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.VideoInfoText);
            this.groupBox7.Location = new System.Drawing.Point(219, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 270);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Video";
            // 
            // VideoInfoText
            // 
            this.VideoInfoText.Location = new System.Drawing.Point(6, 19);
            this.VideoInfoText.Multiline = true;
            this.VideoInfoText.Name = "VideoInfoText";
            this.VideoInfoText.ReadOnly = true;
            this.VideoInfoText.Size = new System.Drawing.Size(198, 244);
            this.VideoInfoText.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AudioInfoText);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // AudioInfoText
            // 
            this.AudioInfoText.Location = new System.Drawing.Point(6, 19);
            this.AudioInfoText.Multiline = true;
            this.AudioInfoText.Name = "AudioInfoText";
            this.AudioInfoText.ReadOnly = true;
            this.AudioInfoText.Size = new System.Drawing.Size(198, 244);
            this.AudioInfoText.TabIndex = 1;
            // 
            // StreamCombo
            // 
            this.StreamCombo.FormattingEnabled = true;
            this.StreamCombo.Location = new System.Drawing.Point(65, 6);
            this.StreamCombo.Name = "StreamCombo";
            this.StreamCombo.Size = new System.Drawing.Size(370, 21);
            this.StreamCombo.TabIndex = 0;
            this.StreamCombo.SelectedIndexChanged += new System.EventHandler(this.StreamCombo_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox8);
            this.settingsTab.Controls.Add(this.groupBox6);
            this.settingsTab.Controls.Add(this.LabelSaturation);
            this.settingsTab.Controls.Add(this.label7);
            this.settingsTab.Controls.Add(this.LabelContrast);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(447, 334);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.SetSharpnessButt);
            this.groupBox8.Controls.Add(this.SharpnessText);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.SetBackLightButt);
            this.groupBox8.Controls.Add(this.BackLightText);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.SaturationLabel);
            this.groupBox8.Controls.Add(this.ContrastLabel);
            this.groupBox8.Controls.Add(this.brightnessLabel);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.TrackBarSaturation);
            this.groupBox8.Controls.Add(this.Labelbrightness);
            this.groupBox8.Controls.Add(this.TrackBarContrast);
            this.groupBox8.Controls.Add(this.TrackBarBrightness);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(6, 75);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(438, 253);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Image adjustment";
            // 
            // SetSharpnessButt
            // 
            this.SetSharpnessButt.Location = new System.Drawing.Point(185, 189);
            this.SetSharpnessButt.Name = "SetSharpnessButt";
            this.SetSharpnessButt.Size = new System.Drawing.Size(106, 23);
            this.SetSharpnessButt.TabIndex = 21;
            this.SetSharpnessButt.Text = "Set sharpness";
            this.SetSharpnessButt.UseVisualStyleBackColor = true;
            this.SetSharpnessButt.Click += new System.EventHandler(this.SetSharpnessButt_Click);
            // 
            // SharpnessText
            // 
            this.SharpnessText.Location = new System.Drawing.Point(79, 189);
            this.SharpnessText.Name = "SharpnessText";
            this.SharpnessText.Size = new System.Drawing.Size(100, 20);
            this.SharpnessText.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Sharpness";
            // 
            // SetBackLightButt
            // 
            this.SetBackLightButt.Location = new System.Drawing.Point(185, 227);
            this.SetBackLightButt.Name = "SetBackLightButt";
            this.SetBackLightButt.Size = new System.Drawing.Size(106, 20);
            this.SetBackLightButt.TabIndex = 18;
            this.SetBackLightButt.Text = "Set back light";
            this.SetBackLightButt.UseVisualStyleBackColor = true;
            this.SetBackLightButt.Click += new System.EventHandler(this.SetBackLightButt_Click);
            // 
            // BackLightText
            // 
            this.BackLightText.Location = new System.Drawing.Point(79, 227);
            this.BackLightText.Name = "BackLightText";
            this.BackLightText.Size = new System.Drawing.Size(100, 20);
            this.BackLightText.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Backlight";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(375, 132);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(22, 13);
            this.SaturationLabel.TabIndex = 15;
            this.SaturationLabel.Text = "     ";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(376, 86);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(28, 13);
            this.ContrastLabel.TabIndex = 14;
            this.ContrastLabel.Text = "       ";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(375, 33);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(22, 13);
            this.brightnessLabel.TabIndex = 13;
            this.brightnessLabel.Text = "     ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Saturation";
            // 
            // TrackBarSaturation
            // 
            this.TrackBarSaturation.Location = new System.Drawing.Point(73, 121);
            this.TrackBarSaturation.Maximum = 255;
            this.TrackBarSaturation.Name = "TrackBarSaturation";
            this.TrackBarSaturation.Size = new System.Drawing.Size(296, 45);
            this.TrackBarSaturation.TabIndex = 7;
            this.TrackBarSaturation.Value = 80;
            this.TrackBarSaturation.Scroll += new System.EventHandler(this.TrackBarSaturation_Scroll);
            // 
            // Labelbrightness
            // 
            this.Labelbrightness.Location = new System.Drawing.Point(0, 0);
            this.Labelbrightness.Name = "Labelbrightness";
            this.Labelbrightness.Size = new System.Drawing.Size(100, 23);
            this.Labelbrightness.TabIndex = 11;
            // 
            // TrackBarContrast
            // 
            this.TrackBarContrast.Location = new System.Drawing.Point(79, 67);
            this.TrackBarContrast.Maximum = 7;
            this.TrackBarContrast.Name = "TrackBarContrast";
            this.TrackBarContrast.Size = new System.Drawing.Size(290, 45);
            this.TrackBarContrast.TabIndex = 3;
            this.TrackBarContrast.Value = 4;
            this.TrackBarContrast.Scroll += new System.EventHandler(this.TrackBarContrast_Scroll);
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.Location = new System.Drawing.Point(79, 19);
            this.TrackBarBrightness.Maximum = 255;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(290, 45);
            this.TrackBarBrightness.TabIndex = 2;
            this.TrackBarBrightness.Value = 150;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contrast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brightness";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.verticalFlipButt);
            this.groupBox6.Controls.Add(this.horizFlipButt);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 63);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flip";
            // 
            // verticalFlipButt
            // 
            this.verticalFlipButt.Location = new System.Drawing.Point(115, 29);
            this.verticalFlipButt.Name = "verticalFlipButt";
            this.verticalFlipButt.Size = new System.Drawing.Size(75, 23);
            this.verticalFlipButt.TabIndex = 1;
            this.verticalFlipButt.Text = "Vertical";
            this.verticalFlipButt.UseVisualStyleBackColor = true;
            this.verticalFlipButt.Click += new System.EventHandler(this.verticalFlipButt_Click);
            // 
            // horizFlipButt
            // 
            this.horizFlipButt.Location = new System.Drawing.Point(24, 29);
            this.horizFlipButt.Name = "horizFlipButt";
            this.horizFlipButt.Size = new System.Drawing.Size(75, 23);
            this.horizFlipButt.TabIndex = 0;
            this.horizFlipButt.Text = "Horizontal";
            this.horizFlipButt.UseVisualStyleBackColor = true;
            this.horizFlipButt.Click += new System.EventHandler(this.horizFlipButt_Click);
            // 
            // LabelSaturation
            // 
            this.LabelSaturation.Location = new System.Drawing.Point(18, 93);
            this.LabelSaturation.Name = "LabelSaturation";
            this.LabelSaturation.Size = new System.Drawing.Size(100, 23);
            this.LabelSaturation.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(96, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            // 
            // LabelContrast
            // 
            this.LabelContrast.Location = new System.Drawing.Point(96, 116);
            this.LabelContrast.Name = "LabelContrast";
            this.LabelContrast.Size = new System.Drawing.Size(100, 23);
            this.LabelContrast.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(621, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "OZEKI IP Camera SDK";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LinkLabel.Location = new System.Drawing.Point(621, 52);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(216, 20);
            this.LinkLabel.TabIndex = 6;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "www.ip-camera-software.com";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(621, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Video camera viewer example";
            // 
            // CameraDetailsBox
            // 
            this.CameraDetailsBox.Controls.Add(this.DetailsText);
            this.CameraDetailsBox.Location = new System.Drawing.Point(468, 504);
            this.CameraDetailsBox.Name = "CameraDetailsBox";
            this.CameraDetailsBox.Size = new System.Drawing.Size(454, 161);
            this.CameraDetailsBox.TabIndex = 9;
            this.CameraDetailsBox.TabStop = false;
            this.CameraDetailsBox.Text = "Camera details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(57, 501);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 20);
            this.heightText.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(211, 501);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 20);
            this.widthText.TabIndex = 13;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(329, 499);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 14;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(7, 20);
            this.DetailsText.Multiline = true;
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.ReadOnly = true;
            this.DetailsText.Size = new System.Drawing.Size(441, 130);
            this.DetailsText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 672);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraDetailsBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.CameraDetailsBox.ResumeLayout(false);
            this.CameraDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox CameraBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button verticalFlipButt;
        private System.Windows.Forms.Button horizFlipButt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox CameraTypeCombo;
        private System.Windows.Forms.TrackBar TrackBarContrast;
        private System.Windows.Forms.TrackBar TrackBarBrightness;
        private System.Windows.Forms.Label Labelbrightness;
        private System.Windows.Forms.Label LabelContrast;
        private System.Windows.Forms.Label LabelSaturation;
        private System.Windows.Forms.TrackBar TrackBarSaturation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AudioInfoText;
        private System.Windows.Forms.GroupBox CameraDetailsBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox StreamCombo;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SaturationLabel;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.TextBox VideoInfoText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SetBackLightButt;
        private System.Windows.Forms.TextBox BackLightText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SetSharpnessButt;
        private System.Windows.Forms.TextBox SharpnessText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DetailsText;
    
    }
}

