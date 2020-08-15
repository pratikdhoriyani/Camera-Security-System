/* 
 * 01_Video_Camera_Viewer
 * You can set an IP camera and change the camera properties with this application 
 * 
 * IPCameraHandler class controlling the IPCamera object
 * 
 * If you want more information http://www.camera-sdk.com/ check our link. 
 */

using System;
using System.Text;
using Ozeki.Camera;
using Ozeki.Media;
using Ozeki.Common;
using System.IO;
using System.Runtime.Serialization;

namespace _01_Video_Camera_Viewer
{
    internal class IpCameraHandler
    {
        private readonly MediaConnector Connector;

        public const string LastCameraInfoPath = "C:\\rtspclient.xml";

        public IpCameraHandler()
        {
            ImageProvider = new DrawingImageProvider();
            Connector = new MediaConnector();
        }

        public OzekiCamera Camera { get; private set; }
        public DrawingImageProvider ImageProvider { get; }

        public event EventHandler<CameraStateEventArgs> CameraStateChanged;
        public event EventHandler<CameraErrorEventArgs> CameraErrorOccured;
        public event EventHandler AvailableStreamsChanged;

        public void ConnectOnvifCamera(string cameraUrl)
        {
            if (Camera != null)
                CloseCamera();
            
            // Gets the camera, which can be reached by the address, and requires authentication.
            Camera = new OzekiCamera(cameraUrl);

            if (Camera == null) return;

            Camera.CameraStateChanged += Camera_CameraStateChanged;
            Camera.AvailableStreamsChanged += Camera_AvailableStreamsChanged;
            Camera.SetupCompleted += Camera_SetupCompleted;
            Camera.CameraErrorOccurred += Camera_CameraErrorOccurred;

            Connector.Connect(Camera.VideoChannel, ImageProvider);

            Camera.Start();
        }

        private void Camera_AvailableStreamsChanged(object sender, EventArgs e)
        {
            var handler = AvailableStreamsChanged;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        private void Camera_SetupCompleted(object sender, GenericEventArgs<RtspClientInfo> e)
        {
            try
            {
                DataContractSerializer ds = new DataContractSerializer(typeof(RtspClientInfo));
                using (FileStream f = new FileStream(LastCameraInfoPath, FileMode.Create))
                    ds.WriteObject(f, e.Item);
            }
            catch { }
        }

        private void Camera_CameraErrorOccurred(object sender, CameraErrorEventArgs e)
        {
            // signal to GUI
            var handler = CameraErrorOccured;
            if (handler != null)
                handler(this, e);
        }

        private void Camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            if(e.State == CameraState.Disconnected && Camera != null)
            {
                Camera.CameraStateChanged -= Camera_CameraStateChanged;
                Camera.CameraErrorOccurred -= Camera_CameraErrorOccurred;
            }

            // signal to GUI
            var handler = CameraStateChanged;
            if (handler != null)
                handler(this, e);
        }

        public void Disconnect()
        {
            CloseCamera();
        }

        private void CloseCamera()
        {
            if (Camera == null)
                return;
            
            Connector.Disconnect(Camera.VideoChannel, ImageProvider);
            Camera.Disconnect();
            
            Camera = null;
        }

        public void Stop()
        {
            if (Camera != null)
            {
                CloseCamera();
                Connector.Dispose();
                ImageProvider.Dispose();
            }
        }

        public string GetDeviceInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"Firmware - " + Camera.CameraInfo.DeviceInfo.Firmware + "\n");
            sb.AppendLine(@"Hardware ID - " + Camera.CameraInfo.DeviceInfo.HardwareId + "\n");
            sb.AppendLine(@"Manufacture - " + Camera.CameraInfo.DeviceInfo.Manufacturer + "\n");
            sb.AppendLine(@"Model - " + Camera.CameraInfo.DeviceInfo.Model + "\n");
            sb.AppendLine(@"Serial number - " + Camera.CameraInfo.DeviceInfo.SerialNumber + "\n");

            return sb.ToString();
        }

        public string StreamInfoAudio()
        {
            if (Camera.CurrentStream.AudioEncoding == null) return "";
            var sb = new StringBuilder();

            sb.AppendLine(" - Audio Encoding \n");
            sb.AppendLine("\t Bitrate - " + Camera.CurrentStream.AudioEncoding.Bitrate + "\n");
            sb.AppendLine("\t Encoding - " + Camera.CurrentStream.AudioEncoding.Encoding + "\n");
            sb.AppendLine("\t Samplerate - " + Camera.CurrentStream.AudioEncoding.SampleRate + "\n");
            sb.AppendLine("\t Session time out - " + Camera.CurrentStream.AudioEncoding.SessionTimeOut + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.AudioEncoding.UseCount + "\n");

            sb.AppendLine(" - Audio Source \n");
            sb.AppendLine("\t Channels - " + Camera.CurrentStream.AudioSource.Channels + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.AudioSource.UseCount + "\n");

            return sb.ToString();
        }

        public string StreamInfoVideo()
        {
            var sb = new StringBuilder();

            sb.AppendLine(" - Video Encoding \n");
            sb.AppendLine("\t Bitrate - " + Camera.CurrentStream.VideoEncoding.BitRate + "\n");
            sb.AppendLine("\t Encoding - " + Camera.CurrentStream.VideoEncoding.Encoding + "\n");
            sb.AppendLine("\t Encoding interval - " + Camera.CurrentStream.VideoEncoding.EncodingInterval + "\n");
            sb.AppendLine("\t Framerate - " + Camera.CurrentStream.VideoEncoding.FrameRate + "\n");
            sb.AppendLine("\t Quality - " + Camera.CurrentStream.VideoEncoding.Quality + "\n");
            sb.AppendLine("\t Resolution - " + Camera.CurrentStream.VideoEncoding.Resolution + "\n");
            sb.AppendLine("\t Session time out - " + Camera.CurrentStream.VideoEncoding.SessionTimeout + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.VideoEncoding.UseCount + "\n");

            sb.AppendLine(" - Video Source \n");
            sb.AppendLine("\t Bounds - " + Camera.CurrentStream.VideoSource.Bounds + "\n");
            sb.AppendLine("\t Use count - " + Camera.CurrentStream.VideoSource.UseCount + "\n");

            return sb.ToString();
        }
    }
}