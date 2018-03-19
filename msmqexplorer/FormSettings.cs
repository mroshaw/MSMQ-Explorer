using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSMQExplorer
{
    public partial class FormSettings : Form
    {
        public Boolean AutoUpdateCount;
        public int AutoUpdateInterval;
        public Boolean AutoUpdateQueue;
        public int AutoUpdateQueueInterval;
        public Boolean ShowUpdatedTimestamp;

        public FormSettings()
        {
            InitializeComponent();
        }

        public void UpdateControls()
        {
            checkBoxAutoRefresh.Checked = AutoUpdateCount;
            numericUpDownRefreshInterval.Value = AutoUpdateInterval;
            checkBoxAutoRefreshQueues.Checked = AutoUpdateQueue;
            numericUpDownRefreshIntervalQueues.Value = AutoUpdateQueueInterval;
            checkBoxShowUpdatedTimestamp.Checked = ShowUpdatedTimestamp;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AutoUpdateCount = checkBoxAutoRefresh.Checked;
            AutoUpdateInterval = Decimal.ToInt16(numericUpDownRefreshInterval.Value);
            AutoUpdateQueue = checkBoxAutoRefreshQueues.Checked;
            AutoUpdateQueueInterval = Decimal.ToInt16(numericUpDownRefreshIntervalQueues.Value);
            ShowUpdatedTimestamp = checkBoxShowUpdatedTimestamp.Checked;
            Close();
        }
    }
}
