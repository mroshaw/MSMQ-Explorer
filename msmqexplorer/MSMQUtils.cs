using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MSMQExplorer
{
    class MSMQUtils
    {
        public static TimeSpan GetTimeSpan(String period, int duration)
        {
            if (period == "Seconds")
            {
                return new TimeSpan(0, 0, 0, duration);
            }
            if (period == "Minutes")
            {
                return new TimeSpan(0, 0, duration, 0);
            }
            return period == "Hours" ? new TimeSpan(0, duration, 0, 0) : new TimeSpan(duration, 0, 0, 0);
        }

        public static MessagePriority GetMessagePriority(String priority)
        {
            switch (priority)
            {
                case "AboveNormal":
                    return MessagePriority.AboveNormal;
                case "High":
                    return MessagePriority.High;
                case "Highest":
                    return MessagePriority.Highest;
                case "Low":
                    return MessagePriority.Low;
                case "Lowest":
                    return MessagePriority.Lowest;
                case "VeryHigh":
                    return MessagePriority.VeryHigh;
                case "VeryLow":
                    return MessagePriority.VeryLow;
                default:
                    return MessagePriority.Normal;
            }
        }
        public static String GetNiceQueueName(String queueName)
        {
            switch (queueName)
            {
                case "system$;JOURNAL":
                    return "Journal messages";
                case "system$;DEADLETTER":
                    return "Dead-letter messages";
                case "system$;DEADXACT":
                    return "Transactional dead-letter messages";
                default:
                    return queueName.Substring(queueName.LastIndexOf("$", StringComparison.Ordinal) + 2);
            }
        }
        public static String GetSimpleQueuePath(String hostName, String queueName)
        {
            return (hostName + @"\" + queueName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Boolean IsMsmqInstalled()
        {
            List<ServiceController> services = ServiceController.GetServices().ToList();
            ServiceController msQue = services.Find(o => o.ServiceName == "MSMQ");
            if (msQue == null)
            {
                return false;
            }
            else
            {
                return msQue.Status == ServiceControllerStatus.Running;
            }
        }
    }
}
