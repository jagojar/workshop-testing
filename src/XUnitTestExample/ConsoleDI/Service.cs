
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDI
{
    public class Service
    {
        private ILoggerUtil _logger;

        public Service(ILoggerUtil logger)
        {
            _logger = logger;
        }

        public Service()
        {

        }

        public ILoggerUtil Logger 
        {
            get
            {
                return _logger;
            } 

            set 
            { 
                _logger = value; 
            } 
        }

        internal void AddLogger(LoggerUtil logger)
        {
            _logger = logger;
        }

        public string LogMessage(string message)
        {
            //throw new NotImplementedException();            
            return _logger.StoreMessage(message);
        }
    }
}
