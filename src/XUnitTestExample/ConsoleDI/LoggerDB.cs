using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI
{
    public class LoggerDB : ILoggerUtil
    {
        public string StoreMessage(string message)
        {
            return $"Sending to database: {message}";
        }
    }
}
