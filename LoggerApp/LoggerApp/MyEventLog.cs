using System;
using System.Diagnostics;

namespace LoggerApp
{
    class MyEventLog
    {
        // The name of source in the Event log
        static string logSource = "logger app";

        // The Information event log
        public static void Error(string message)
        {
            Console.WriteLine(message);
            EventLog log = new EventLog();
            log.Source = logSource;
            log.WriteEntry(message, EventLogEntryType.Error);
        }

        // The Information event log
        public static void Info(string message)
        {
            Console.WriteLine(message);
            EventLog log = new EventLog();
            log.Source = logSource;
            log.WriteEntry(message, EventLogEntryType.Information);
        }

        // The Information event log
        public static void Warning(string message)
        {
            Console.WriteLine(message);
            EventLog log = new EventLog();
            log.Source = logSource;
            log.WriteEntry(message, EventLogEntryType.Warning);
        }

        // The Information event log
        public static void Success(string message)
        {
            Console.WriteLine(message);
            EventLog log = new EventLog();
            log.Source = logSource;
            log.WriteEntry(message, EventLogEntryType.SuccessAudit);
        }
    }
}
