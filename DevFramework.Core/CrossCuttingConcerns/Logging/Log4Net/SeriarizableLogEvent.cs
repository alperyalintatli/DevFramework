using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
   public class SeriarizableLogEvent
    {
        private LoggingEvent _loggingEvent;
        public SeriarizableLogEvent(LoggingEvent loggingEvent)
        {
            _loggingEvent = loggingEvent;
        }
        public string UserName { get { return _loggingEvent.UserName; }}
        public object MessageObject { get { return _loggingEvent.MessageObject; } }
    }
}
