#region

using System;

#endregion

namespace MSMQExplorer
{
    internal class SystemMessageQueue
    {
        public SystemMessageQueue(String hostName, String queueName, String displayName)
        {
            QueueName = queueName;
            QueuePath = MsmqMessaging.GetQueuePath(hostName, queueName);
            DisplayName = displayName;
        }

        public String QueueName { get; set; }
        public String QueuePath { get; set; }

        public String DisplayName { get; set; }
    }
}