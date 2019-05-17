using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MSMQExplorer
{
    class MSMQQueue
    {
        public String hostName;
        public String name;
        public String queuePath;
        public MessageQueue messageQueue;
        private Boolean isPrivate;
        private Boolean isTransactional;
        private Boolean isPublic;
        private Boolean isJournal;
        private Boolean isRemoteQueue;
        
        private List<Message> messagesList;

        public MSMQQueue(String Host, String Name)
        {
            queuePath = "FormatName:DIRECT=OS:" + hostName + @"\" + name;
            MessageQueue messageQueue = new MessageQueue(queuePath);
        }

        public void SendMessage(MSMQMessage message)
        {

            // Check if transaction is required
            if ((!isPrivate && message.useTransaction) || isTransactional)
            {
                // Create a message queuing transaction.
                MessageQueueTransaction transaction = new MessageQueueTransaction();
                // Process MQ transaction
                try
                {
                    transaction.Begin();
                    messageQueue.Send(message, message.label, transaction);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Abort();
                    throw;
                }
            }
            else
            {
                messageQueue.Send(message, message.label);
            }
        }

        public MSMQMessage ReceiveMessage(String format)
        {

            // Return message text
            List<byte> messageByteList = new List<Byte>();
            messageByteList = null;
            MSMQMessage receiveMessage = new MSMQMessage(null, null, format, 0, null, 0, null, false, false);

            if (isRemoteQueue)
            {
                /* TransactionScope dstTransactionScope = new TransactionScope();
                message = mq.Receive(MessageQueueTransactionType.Automatic);
                dstTransactionScope.Complete(); */
            }
            else
            {
                if (isTransactional)
                {
                    MessageQueueTransaction transaction = new MessageQueueTransaction();

                    transaction.Begin();
                    receiveMessage.message = messageQueue.Receive(TimeSpan.FromSeconds(2.0), transaction);
                    transaction.Commit();
                }
                else
                {
                    receiveMessage.message = messageQueue.Receive(TimeSpan.FromSeconds(2.0));
                }
            }
            receiveMessage.FormatMessage();
            return receiveMessage;
        }


        public MSMQMessage PreviewMessage(String format, string messageId)
        {
            Message message = GetMessageById(messageId);
            MSMQMessage previewMessage = new MSMQMessage(null, null, format, 0, null, 0, null, false, false);
            previewMessage.message = message;
            previewMessage.FormatMessage();
            return previewMessage;
        }

        /// <summary>
        ///     Helper function to count the number of messages in a queue
        /// </summary>
        /// <param name="q"></param>
        /// <param name="cursor"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        protected Message PeekWithoutTimeout(MessageQueue q, Cursor cursor, PeekAction action)
        {
            Message ret = null;
            try
            {
                ret = q.Peek(new TimeSpan(1), cursor, action);
            }
            catch (Exception mqe)
            {
                if (mqe is MessageQueueException)
                {
                    if (!mqe.Message.ToLower().Contains("timeout"))
                    {
                        throw;
                    }
                }
                else
                {
                    throw;
                }
            }

            return ret;
        }

        /// <summary>
        /// <summary>
        ///     Get the number of messages in the specified queue
        /// </summary>
        /// <param name="queue">MSMQ queue object</param>
        /// <returns></returns>
        private int GetMessageCount()
        {
            try
            {
                int count = 0;
                if (messageQueue == null)
                {
                    return -1;
                }

                Cursor cursor = messageQueue.CreateCursor();

                Message m = PeekWithoutTimeout(messageQueue, cursor, PeekAction.Current);
                if (m == null) return count;
                count = 1;
                while ((m = PeekWithoutTimeout(messageQueue, cursor, PeekAction.Next)) != null)
                {
                    count++;
                }
                return count;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void Purge()
        {
            messageQueue.Purge();
        }

        public void RefreshRecMessageList()
        {
            messageQueue.MessageReadPropertyFilter.SetAll();
            // Populate an array with copies of all the messages in the queue.
            Message[] messages = messageQueue.GetAllMessages();
            messagesList = messages.ToList();
        }

        [DllImport("mqrt.dll")]
        public static extern int MQMoveMessage(IntPtr sourceQueue, IntPtr targetQueue, long lookupId,
            IDtcTransaction transaction);

        public Message GetMessageById(string messageId)
        {
            RefreshRecMessageList();
            Message foundMessage = new Message();
            // loop through all the messages 
            foreach (Message message in messagesList.Where(message => message.Id.Equals(messageId)))
            {
                foundMessage = message;
            }

            return foundMessage;
        }

        /// <summary>
        ///     Delete the specified message from the specified queue on the host machine
        /// </summary>
        /// <param name="queueName"></param>
        /// <param name="messageId">ID of the message to delete</param>
        public void DeleteMessageById(string messageId)
        {

            // Set this property to read all properties
            messageQueue.MessageReadPropertyFilter.SetAll();

            // Get a message enumerator we can use to go through all the messages
            MessageEnumerator enumerator = messageQueue.GetMessageEnumerator2();

            // Loop through all the messages 
            while (enumerator.MoveNext(new TimeSpan(0, 0, 1)))
            {
                // Get a reference to the current message
                Message message = enumerator.Current;
                if (message == null) continue;
                if (message.Id.Equals(messageId))
                {
                    messageQueue.ReceiveById(message.Id);
                }
            }
        }
    }
}
