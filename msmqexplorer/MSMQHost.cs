using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MSMQExplorer
{
    class MSMQHost
    {
        public String hostName { get; set; }
        private Boolean isMQInstalled;

        public List<MSMQQueue> _privateQueueList { get; set; }
        public List<MSMQQueue> _publicQueueList { get; set; }
        public List<MSMQQueue> _systemQueueList { get; set; }

        public MSMQHost(String HostName, Boolean includeSystem)
        {
            hostName = hostName;
            // RefreshQueueList(includeSystem);
        }

        private List<MSMQQueue> CreateQueueList(MessageQueue[] queueList)
        {
            List<MSMQQueue> msmqQueues = new List<MSMQQueue>();
            MSMQQueue msmqQueue;
            foreach (MessageQueue queue in queueList)
            {
                msmqQueue = new MSMQQueue(hostName, queue.QueueName);
                msmqQueue.messageQueue = queue;
                msmqQueues.Add(msmqQueue);
            }
            return msmqQueues;
        }

        /// <summary>
        ///     Returns a list of all private queues on the specified host
        /// </summary>
        /// <param name="hostName"></param>
        /// <returns></returns>
        private void GetPrivateQueues()
        {
            MessageQueue[] privateQueueList;
            try
            {
                privateQueueList = MessageQueue.GetPrivateQueuesByMachine("FormatName:DIRECT=OS:" + hostName);
                _privateQueueList = CreateQueueList(privateQueueList);
            }
            catch
            {
                privateQueueList = MessageQueue.GetPrivateQueuesByMachine(hostName);
                _privateQueueList = CreateQueueList(privateQueueList);
            }
        }

        /// <summary>
        ///     Returns a list of all public queues on the specified host
        /// </summary>
        /// <param name="hostName"></param>
        /// <returns></returns>
        private void GetPublicQueues()
        {
            MessageQueue[] publicQueueList;
            try
            {
                publicQueueList = MessageQueue.GetPublicQueuesByMachine(hostName);
            }
            catch (Exception)
            {
                publicQueueList = null;
            }
        }

        /// <summary>
        ///     Populates the system queues (Journal, Dead Letter and Dead Letter X
        /// </summary>
        /// <param name="hostName"></param>
        /// <returns></returns>
        private void GetSystemQueues()
        {
            SystemMessageQueue[] systemQueueList;
            // Get a list of queues on the specified computer.
            systemQueueList = GetSystemQueuesByMachine(hostName);
        }

        public static SystemMessageQueue[] GetSystemQueuesByMachine(String hostName)
        {
            SystemMessageQueue[] queueList = new SystemMessageQueue[3];

            try
            {
                // Get a list of queues on the specified computer.
                // System Journal
                queueList[0] = new SystemMessageQueue(hostName, "system$;JOURNAL", "Journal messages");

                // Get the Dead Letter queue
                queueList[1] = new SystemMessageQueue(hostName, "system$;DEADLETTER", "Dead-letter messages");

                // Transactional Dead Letter Queue
                queueList[2] = new SystemMessageQueue(hostName, "system$;DEADXACT", "Transactional dead-letter messages");
            }
            catch (Exception)
            {
                return queueList;
            }

            return queueList;
        }

        public void CreateQueueByName(String queueType, String queueName, Boolean isTransactional)
        {
            if (String.IsNullOrEmpty(queueType) || String.IsNullOrEmpty(queueName)) return;
            String queuePath = MSMQUtils.GetSimpleQueuePath(hostName, queueType + queueName);
            MessageQueue.Create(queuePath, isTransactional);
        }

        public void DeleteQueueByName(String queueName)
        {
            if (String.IsNullOrEmpty(hostName) || String.IsNullOrEmpty(queueName)) return;
            String queuePath = MSMQUtils.GetSimpleQueuePath(hostName, queueName);
            MessageQueue.Delete(queuePath);
        }

        public void RefreshQueueList(Boolean includeSystem)
        {
            GetPrivateQueues();
            GetPublicQueues();
            if (includeSystem)
            {
                GetSystemQueues();
            }
        }
        public void RefereshQueueMessageListByName()
        {

        }
    }
}
