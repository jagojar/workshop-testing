using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI
{
    public class LoggerUtil: ILoggerUtil
    {
        public string StoreMessage(string message)
        {
            return $"Logging message from service {message}";
        }
    }
}
