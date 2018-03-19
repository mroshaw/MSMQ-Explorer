#region

using System.IO;
using System.Messaging;
using System.Text;

#endregion

namespace MSMQExplorer
{
    internal class StringMessageFormatter : IMessageFormatter
    {
        public object Clone()
        {
            return new StringMessageFormatter();
        }

        public bool CanRead(Message message)
        {
            return true;
        }

        public object Read(Message msg)
        {
            Stream stm = msg.BodyStream;
            if (stm == null)
                return null;
            StreamReader reader = new StreamReader(stm);
            return reader.ReadToEnd();
        }

        public void Write(Message msg, object obj)
        {
            if (obj == null)
            {
                msg.BodyStream = null;
                return;
            }
            //Declare a buffer.
            //Place the string into the buffer using UTF8 encoding.
            byte[] buff = Encoding.UTF8.GetBytes(obj.ToString());
            //Create a new MemoryStream object passing the buffer.
            Stream stm = new MemoryStream(buff);
            //Assign the stream to the message's BodyStream property.
            msg.BodyStream = stm;
        }
    }
}