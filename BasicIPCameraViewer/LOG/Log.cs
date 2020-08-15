using System;

namespace _01_Video_Camera_Viewer.LOG
{
    internal class Log
    {
        private static string _log;

        public static void Write(string logMessage)
        {
            _log = DateTime.Now + " | " + logMessage;
            LogMessageReceived(_log);
        }

        public static event EventHandler<LogEventArgs> OnLogMessageReceived;

        private static void LogMessageReceived(string msg)
        {
            var handler = OnLogMessageReceived;
            if (handler != null)
                handler(null, new LogEventArgs(msg));
        }
    }
}