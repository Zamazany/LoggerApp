using Serilog;

namespace LoggerApp
{
    class LoggerConsole : ILogger
    {
        // The Information consol log
        public void Info(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Information(message);
        }

        // The Warning consol log
        public void Warning(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Warning(message);
        }

        // The Error console log
        public void Error(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Error(message);
        }
    }
}
