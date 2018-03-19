#region

using System;
using System.Messaging;
using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    public partial class FormQueueProperties : Form
    {
        private readonly MessageQueue _queue;

        public FormQueueProperties(MessageQueue queue)
        {
            InitializeComponent();
            _queue = queue;
            PopulateQueueDetails();
            buttonApply.Enabled = false;
        }

        private void PopulateQueueDetails()
        {
            try
            {
                textBoxQueueName.Text = _queue.QueueName;
                textBoxLabel.Text = _queue.Label;
                textBoxTypeId.Text = _queue.Id.ToString();
                long maxJournalSize = _queue.MaximumJournalSize;
                long maxQueueSize = _queue.MaximumQueueSize;
                if (maxJournalSize == 4294967295)
                {
                    numericUpDownJournalLimit.Value = 0;
                    checkBoxLimitJournalStorage.Checked = false;
                }
                else
                {
                    numericUpDownJournalLimit.Value = maxJournalSize;
                    checkBoxLimitJournalStorage.Checked = true;
                }
                if (maxQueueSize == 4294967295)
                {
                    numericUpDownQueueLimit.Value = 0;
                    checkBoxLimitStorage.Checked = false;
                }
                else
                {
                    numericUpDownQueueLimit.Value = maxQueueSize;
                    checkBoxLimitStorage.Checked = true;
                }


                checkBoxJournalEnabled.Checked = _queue.UseJournalQueue;
                checkBoxAuthenticated.Checked = _queue.Authenticate;
                comboBoxPrivacyLevel.Text = _queue.EncryptionRequired.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            buttonApply.Enabled = false;
        }

        private void ApplyChanges()
        {
            // _queue.QueueName = textBoxQueueName.Text;
            _queue.Label = textBoxLabel.Text;

            if (checkBoxJournalEnabled.Checked)
            {
                _queue.MaximumJournalSize = (long) numericUpDownJournalLimit.Value;
            }
            else
            {
                _queue.MaximumJournalSize = 4294967295;
            }

            if (checkBoxLimitStorage.Checked)
            {
                _queue.MaximumQueueSize = (long) numericUpDownQueueLimit.Value;
            }
            else
            {
                _queue.MaximumQueueSize = 4294967295;
            }

            _queue.UseJournalQueue = checkBoxJournalEnabled.Checked;
            _queue.Authenticate = checkBoxAuthenticated.Checked;
            EncryptionRequired privacy;
            string privacyRequired = comboBoxPrivacyLevel.Text;

            switch (privacyRequired)
            {
                case "Optional":
                    privacy = EncryptionRequired.Optional;
                    break;
                case "Body":
                    privacy = EncryptionRequired.Body;
                    break;
                default:
                    privacy = EncryptionRequired.None;
                    break;
            }

            _queue.EncryptionRequired = privacy;
        }

        private void textBoxQueueName_TextChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void textBoxTypeId_TextChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxLimitStorage_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void numericUpDownQueueLimit_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxAuthenticated_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void comboBoxPrivacyLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxJournalEnabled_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxLimitJournalStorage_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void numericUpDownJournalLimit_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void numericUpDownJournalLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonApply.Enabled = true;
        }
    }
}