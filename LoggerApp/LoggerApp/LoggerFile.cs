using System.Configuration;
using Serilog;

namespace LoggerApp
{
    public static class LoggerFile
    {
        // The path for a log file, it is set in the App.config
        static string logPath = ConfigurationManager.AppSettings["logPath"];

        // The Information log that will save it's output in the file and also write it in console
        public static void LogToFileAndConsole(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Information(message);            
        }

        // The Information file log
        public static void Info(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Information(message);
        }

        // The Warning file log
        public static void Warning(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Warning(message);
        }

        // The Error file log
        public static void Error(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Error(message);
        }

        // The Fatal Error file log
        public static void FatalError(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Fatal(message);
        }
    }
}
