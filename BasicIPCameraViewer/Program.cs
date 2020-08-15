/************************************************************************************************************
 * OZEKI CAMERA SDK
 * http://www.camera-sdk.com/
 * 
 * Example project
 * Title: Video camera viewer with basic settings
 * Description: This example demonstrates how you can get information of the camera
 * and show how you can set such image properties like width, height, vertical and horizontal alignment,
 * brightness, contrast, saturation, sharpness, backlight, white balance and framerate.  
 * 
 * Documentation:
 * http://www.camera-sdk.com/p_18-onvif.html
 * 
 * License:
 * This example can be freely used, distributed and modified according to the
 * license agreement at the following webpage: http://camera-sdk.com/p_241-license.html 
 * *********************************************************************************************************/

using System;
using System.Windows.Forms;

namespace _01_Video_Camera_Viewer
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}