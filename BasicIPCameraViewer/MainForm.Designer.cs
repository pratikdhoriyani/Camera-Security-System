using System.Windows.Forms;

namespace _01_Video_Camera_Viewer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_compose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.label4 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CameraBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.tb_cameraUrl);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btn_compose);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(147, 43);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(80, 23);
            this.button_Connect.TabIndex = 18;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(233, 43);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 22;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(83, 17);
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.ReadOnly = true;
            this.tb_cameraUrl.Size = new System.Drawing.Size(280, 20);
            this.tb_cameraUrl.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Camera URL:";
            // 
            // btn_compose
            // 
            this.btn_compose.Location = new System.Drawing.Point(369, 15);
            this.btn_compose.Name = "btn_compose";
            this.btn_compose.Size = new System.Drawing.Size(75, 23);
            this.btn_compose.TabIndex = 19;
            this.btn_compose.Text = "Compose";
            this.btn_compose.UseVisualStyleBackColor = true;
            this.btn_compose.Click += new System.EventHandler(this.btn_compose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logListBox);
            this.groupBox3.Location = new System.Drawing.Point(234, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event log";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(11, 19);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(438, 108);
            this.logListBox.TabIndex = 0;
            // 
            // CameraBox
            // 
            this.CameraBox.Controls.Add(this.videoViewerWF1);
            this.CameraBox.Location = new System.Drawing.Point(234, 98);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(450, 360);
            this.CameraBox.TabIndex = 3;
            this.CameraBox.TabStop = false;
            this.CameraBox.Text = "Live camera ";
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(0, 19);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(450, 335);
            this.videoViewerWF1.TabIndex = 0;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(284, 458);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 20);
            this.heightText.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(442, 458);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 20);
            this.widthText.TabIndex = 13;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(568, 455);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 14;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 632);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video camera viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.CameraBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


         private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox CameraBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ListBox logListBox;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private Button button_Connect;
        private Button button_Disconnect;
        private TextBox tb_cameraUrl;
        private Label label18;
        private Button btn_compose;
    
    }
}

