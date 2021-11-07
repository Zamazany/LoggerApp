using Serilog;

namespace LoggerApp
{
    class LoggerConsole
    {
        // The Information consol log
        public static void Info(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Information(message);
        }

        // The Warning consol log
        public static void Warning(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Warning(message);
        }

        // The Error console log
        public static void Error(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Error(message);
        }

        // The Fatal Error console log
        public static void FatalError(string message)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

            Log.Fatal(message);
        }
    }
}
