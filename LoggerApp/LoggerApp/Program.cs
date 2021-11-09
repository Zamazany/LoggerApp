using System;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Some Error");

            } catch(Exception ex)
            {
                new LoggerConsole().Error(ex.Message);
                new LoggerFile().Error(ex.Message);
                new LoggerEventLog().Error(ex.Message);
            }
            Console.ReadLine(); // this is unnecessery but its easier to check the Console logs with it
        }
    }
}
