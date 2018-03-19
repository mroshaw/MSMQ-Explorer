using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQExplorer
{
    class MSMQLog
    {
        public DateTime TimeStamp;
        public String LogType;
        public String LogEntry;

        public MSMQLog(DateTime timeStamp, String logType, String logEntry)
        {
            TimeStamp = timeStamp;
            LogType = logType;
            LogEntry = logEntry;
        }
    }
}
