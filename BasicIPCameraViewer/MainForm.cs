/* 
 * 01_Video_Camera_Viewer
 * 
 * This is the mainform 
 * 
 * You can set an IP camera and change the camera properties with this application 
 * If you want more information http://www.camera-sdk.com/ check our link. 
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using _01_Video_Camera_Viewer.LOG;
using System.IO;
using System.Runtime.Serialization;

namespace _01_Video_Camera_Viewer
{
    public partial class MainForm : Form
    {
        private IpCameraHandler _model;

        private readonly CameraURLBuilderWF _myCameraUrlBuilder;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                if (File.Exists(IpCameraHandler.LastCameraInfoPath))
                {
                    DataContractSerializer js = new DataContractSerializer(typeof(RtspClientInfo));
                    using (var stream = new FileStream(IpCameraHandler.LastCameraInfoPath, FileMode.Open))
                    {
                        var client = js.ReadObject(stream) as RtspClientInfo;
                        RtspClientFactory.RegisterClient(client);
                    }
                }
            }
            catch { }

            _myCameraUrlBuilder = new CameraURLBuilderWF();
            Log.OnLogMessageReceived += Log_OnLogMessageReceived;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _model = new IpCameraHandler();
            _model.AvailableStreamsChanged += _model_AvailableStreamsChanged;
            _model.CameraStateChanged += ModelCameraStateChanged;
            _model.CameraErrorOccured += ModelCameraErrorOccured;

            InitializeViewer();
            videoViewerWF1.SetImageProvider(_model.ImageProvider);
        }

        private void _model_AvailableStreamsChanged(object sender, EventArgs e)
        {
            GetCameraStreams();
        }

        private void InitializeViewer()
        {
            ControlToCenter();

            heightText.Text = videoViewerWF1.Size.Height.ToString(CultureInfo.InvariantCulture);
            widthText.Text = videoViewerWF1.Size.Width.ToString(CultureInfo.InvariantCulture);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _model.Stop();
        }

        private void ModelCameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                Log.Write("Camera state: " + e.State);
                switch (e.State)
                {
                    // The list of streams become available at the Connected state.
                    case CameraState.Streaming:
                        button_Connect.Enabled = false;
                        videoViewerWF1.Start();
                        ClearFields();
                        GetCameraStreams();
                        button_Disconnect.Enabled = true;
                        if (_model.Camera.UriType != CameraUriType.RTSP)
                            InitializeTrackBars();
                        break;

                    case CameraState.Disconnected:
                        button_Disconnect.Enabled = false;
                        videoViewerWF1.Stop();
                        button_Connect.Enabled = true;
                        break;
                }
            });
        }

        private void GetCameraStreams()
        {
            if (_model.Camera.AvailableStreams.Any())
            {
                var selected = 0;
                InvokeGuiThread(() =>
                {
                    for (var index = 0; index < _model.Camera.AvailableStreams.Count; index++)
                    {
                        if (_model.Camera.CurrentStream.Name == _model.Camera.AvailableStreams[index].Name)
                        {
                            selected = index;
                        }
                        var name = _model.Camera.AvailableStreams[index].Name + " " + (_model.Camera.AvailableStreams[index].VideoEncoding != null ? _model.Camera.AvailableStreams[index].VideoEncoding.Resolution.ToString() : "_" + index);
                        
                    }
                
                });
            }
        }


        private void ModelCameraErrorOccured(object sender, CameraErrorEventArgs e)
        {
            InvokeGuiThread(() => Log.Write("Camera error: " + (e.Details ?? e.Error.ToString())));
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = new LinkLabel.Link {LinkData = "http://www.camera-sdk.com/"};

            if (link.LinkData != null) Process.Start(link.LinkData as string);
        }

        private void ClearFields()
        {
            
        }



        private void StreamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null || combo.SelectedIndex == -1) return;
       

        }


        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }

        private void Flip(object sender, EventArgs e)
        {

            videoViewerWF1.FlipMode = FlipMode.None;
        }

        private void btn_compose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK) return;

            tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;

            button_Connect.Enabled = true;
        }

        //***********************************************
        // Connect - Disconnect
        //***********************************************

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("RTSP://"))
                Log.Write("Connecting to a stream of ONVIF device by RTSP");
            else if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("HTTP://"))
                Log.Write("Connecting to ONVIF device by HTTP");
            else if (tb_cameraUrl.Text.ToUpper().Trim().StartsWith("USB://"))
                Log.Write("Connecting to Webcamera device");
            ConnectIpCam();
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (_model.Camera != null)
                _model.Disconnect();

            button_Disconnect.Enabled = false;

            button_Connect.Enabled = true;

            ClearFields();
        }

        private void ConnectIpCam()
        {
            _model.ConnectOnvifCamera(_myCameraUrlBuilder.CameraURL);
            videoViewerWF1.Start();
        }

        //***********************************************
        // LOG
        //***********************************************

        private void Log_OnLogMessageReceived(object sender, LogEventArgs e)
        {
            InvokeGuiThread(() =>
            {
                logListBox.Items.Add(e.LogMessage);
                LogScroll();
            });
        }

        private void LogScroll()
        {
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
            logListBox.SelectedIndex = -1;
        }

        //***********************************************
        // Image size
        //***********************************************

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var height = int.Parse(heightText.Text);
                var width = int.Parse(widthText.Text);
                if (!(height < 40 || height > 320)) // 40 - 320
                    videoViewerWF1.Height = height;
                else
                {
                    if (!(height >= 40))
                    {
                        videoViewerWF1.Height = 40;
                        heightText.Text = videoViewerWF1.Height.ToString();
                    }

                    if (!(height <= 320))
                    {
                        videoViewerWF1.Height = 320;
                        heightText.Text = videoViewerWF1.Height.ToString();
                    }
                }
                if (!(width < 50 || width > 400)) // 50 - 400
                    videoViewerWF1.Width = width;
                else
                {
                    if (!(width >= 50))
                    {
                        videoViewerWF1.Width = 50;
                        widthText.Text = videoViewerWF1.Width.ToString();
                    }
                    videoViewerWF1.Width = 50;
                    if (!(width <= 400))
                    {
                        videoViewerWF1.Width = 400;
                        widthText.Text = videoViewerWF1.Width.ToString();
                    }
                }
                ControlToCenter();
            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }
        }

        private void ControlToCenter()
        {
            videoViewerWF1.Anchor = AnchorStyles.None;
            videoViewerWF1.Dock = DockStyle.None;
            var pt = CameraBox.DisplayRectangle.Location;
            pt.X += (CameraBox.DisplayRectangle.Width - videoViewerWF1.Width)/2;

            pt.Y += (CameraBox.DisplayRectangle.Height - videoViewerWF1.Height)/2;

            videoViewerWF1.Location = pt;
        }

        //***********************************************
        // Image Settings
        //***********************************************

        private void TrackbarPropertiesScroll(object sender, EventArgs e)
        {
            var config = new CameraImaging
            {
            };

            if (_model.Camera.ImagingSettings != null)
            {
                _model.Camera.ImagingSettings.SetAttributes(config);
                _model.Camera.ImagingSettings.RefreshProperties();
             
            }

            if (_model.Camera.CurrentStream.VideoEncoding == null) return;
            _model.Camera.CurrentStream.VideoEncoding.SetAttributes(new IPCameraVideoEncoding
            {
            });
            _model.Camera.CurrentStream.VideoEncoding.RefreshProperties();
        }

     
        private void InitializeTrackBars()
        {
          
        }

    }
}
