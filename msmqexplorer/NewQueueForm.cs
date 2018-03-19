#region

using System;
using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    public partial class NewQueueForm : Form
    {
        public NewQueueForm(String host)
        {
            InitializeComponent();
            textBoxHost.Text = host;
        }

        public String QueueType { get; set; }
        public String QueueName { get; set; }
        public Boolean IsTransaction { get; set; }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            QueueType = comboBoxQueueType.Text;
            QueueName = textBoxQueueName.Text;
            IsTransaction = checkBoxTransactional.Checked;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}