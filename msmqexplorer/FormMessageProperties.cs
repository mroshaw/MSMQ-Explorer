#region

using System;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.Messaging;
using System.Security.Principal;
using System.Windows.Forms;
using Message = System.Messaging.Message;

#endregion

namespace MSMQExplorer
{
    public partial class FormMessageProperties : Form
    {
        private readonly Message _message;
        private readonly MessageQueue _queue;

        public FormMessageProperties(Message message, MessageQueue queue)
        {
            InitializeComponent();
            _message = message;
            _queue = queue;
            PopulateMessageDetails();
        }

        private void PopulateMessageDetails()
        {
            try
            {
                // General Tab
                textBoxLabel.Text = _message.Label;
                textBoxId.Text = _message.Id;
                textBoxClass.Text = _message.MessageType.ToString();
                textBoxSent.Text = _message.SentTime.ToString(CultureInfo.InvariantCulture);
                textBoxArrived.Text = _message.ArrivedTime.ToString(CultureInfo.InvariantCulture);
                textBoxTracked.Text = _message.UseTracing.ToString(CultureInfo.InvariantCulture);
                textBoxLookupId.Text = _message.LookupId.ToString(CultureInfo.InvariantCulture);

                // Queues Tab
                MessageQueue destination = _message.DestinationQueue;
                MessageQueue administration = _message.AdministrationQueue;
                MessageQueue response = _message.ResponseQueue;

                try
                {
                    if (_queue != null)
                    {
                        textBoxFormatName.Text = _queue.FormatName;
                        textBoxName.Text = _queue.QueueName;
                    }
                }
                catch (Exception)
                {
                    textBoxFormatName.Text = "";
                    textBoxName.Text = "";
                }

                if (destination != null)
                {
                    textBoxFormatNameDest.Text = destination.FormatName;
                }

                if (administration != null)
                {
                    textBoxFormatNameAdmin.Text = administration.FormatName;
                    textBoxNameAdmin.Text = administration.QueueName;
                }
                if (response != null)
                {
                    textBoxFormatNameResponse.Text = response.FormatName;
                    textBoxNameResponse.Text = response.QueueName;
                }

                // Sender tab
                // textBoxSourceGUID.Text = _message.SourceMachineGuid;
                try
                {
                    textBoxSrcName.Text = _message.SourceMachine;
                }
                catch (Exception)
                {
                    textBoxSrcName.Text = "";
                }

                SecurityIdentifier sid = new SecurityIdentifier(_message.SenderId, 0);
                UserPrincipal user = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain),
                    IdentityType.Sid, sid.ToString());
                if (user != null)
                {
                    textBoxUser.Text = user.Name;
                    textBoxSID.Text = sid.ToString();
                }
                textBoxAuthenticated.Text = _message.Authenticated.ToString();
                textBoxHash.Text = _message.HashAlgorithm.ToString();
                textBoxEncrypted.Text = _message.UseEncryption.ToString();
                textBoxEncAlgo.Text = _message.EncryptionAlgorithm.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}