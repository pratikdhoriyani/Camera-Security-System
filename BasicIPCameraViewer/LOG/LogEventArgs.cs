using System;

namespace _01_Video_Camera_Viewer.LOG
{
    internal class LogEventArgs : EventArgs
    {
        public string LogMessage;

        public LogEventArgs(string log)
        {
            LogMessage = log;
        }
    }
}