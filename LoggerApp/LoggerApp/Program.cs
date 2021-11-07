using System;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0; // visual studio will not let me complie divide by 0 in other way
                a = 1 / a;

            }catch(Exception ex)
            {
                LoggerConsole.Error(ex.Message);
                LoggerFile.LogToFileAndConsole(ex.Message);
                MyEventLog.Error(ex.Message);
            }
            Console.ReadLine(); // this is unnecessery but its easier to check the Console logs with it
        }
    }
}
