using System.Configuration;
using Serilog;

namespace LoggerApp
{
    class LoggerFile : ILogger
    {
        // The path for a log file, it is set in the App.config
        static string logPath = ConfigurationManager.AppSettings["logPath"];

        // The Information file log
        public void Info(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Information(message);
        }

        // The Warning file log
        public void Warning(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Warning(message);
        }

        // The Error file log
        public void Error(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Error(message);
        }
    }
}
