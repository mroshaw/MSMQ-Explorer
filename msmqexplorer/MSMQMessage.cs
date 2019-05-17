using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Xml;
using System.IO;

namespace MSMQExplorer
{
    class MSMQMessage
    {
        public List<byte> messageByteList;
        public String label;
        public String format;
        public Boolean useTransaction;
        public Boolean isPrivateQueue;
        public int timeToReachQueue;
        public String timeToReachQueuePeriod;
        public int timeToReceive;
        public String timeToReceivePeriod;
        public Boolean useDeadLetterQueue;
        public Boolean useEncryption;
        public Boolean useTracing;
        public Boolean useJournal;
        public String priority;
        public Message message;

        public MSMQMessage(List<byte> MessageByteList, String Label, String Format, int TimeToReachQueue, String TimeToReachQueuePeriod, int TimeToReceive,
            String TimeToReceivePeriod, Boolean UseTransaction, Boolean UseEncryption)
        {
            messageByteList = MessageByteList;
            label = Label;
            format = Format;
            timeToReachQueue = TimeToReachQueue;
            timeToReachQueuePeriod = TimeToReachQueuePeriod;
            timeToReceive = TimeToReceive;
            timeToReceivePeriod = TimeToReceivePeriod;
            useTransaction = UseTransaction;
            useEncryption = UseEncryption;

            SetTimeTo();
            SetOtherAttribs();
            FormatMessage();
        }


        public void SetOtherAttribs()
        {
            // Set other message attributes
            message.UseEncryption = useEncryption;
            message.UseJournalQueue = useJournal;
            message.UseTracing = useTracing;
            message.Priority = MSMQUtils.GetMessagePriority(priority);
        }

        public void SetTimeTo()
        {
            if (timeToReceive != 0)
            {
                message.TimeToBeReceived = MSMQUtils.GetTimeSpan(timeToReceivePeriod, timeToReceive);
            }

            if (timeToReachQueue != 0)
            {
                message.TimeToReachQueue = MSMQUtils.GetTimeSpan(timeToReachQueuePeriod, timeToReachQueue);
            }
        }

        public void FormatMessage()
        {
            if (format == "XML")
            {
                XmlMessageFormatter _xmlFormatter = new XmlMessageFormatter(new[] { typeof(XmlDocument) });
                message.Formatter = _xmlFormatter;
                XmlDocument messageXml = new XmlDocument();
                messageXml.LoadXml(StringTools.GetStringFromByteList(messageByteList));
                message = new Message(messageXml);
            }
            else if (format == "text")
            {
                // Create message using Text Formatter
                StringMessageFormatter _stringFormatter = new StringMessageFormatter();
                message = new Message(StringTools.GetStringFromByteList(messageByteList), _stringFormatter);
            }
            else if (format == "binary")
            {
                // Create message using Binary formatter
                 message = new Message { BodyStream = new MemoryStream(messageByteList.ToArray()) };
            }
        }
    }

}
