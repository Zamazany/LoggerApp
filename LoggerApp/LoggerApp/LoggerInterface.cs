using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp
{
    public interface ILogger
    {
        void Warning(string message);

        void Error(string message);

        void Info(string message);
    }
}
