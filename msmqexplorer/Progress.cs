#region

using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        public void Show(string labelToShow)
        {
            progressLabel.Text = labelToShow;
            Show();
            Application.DoEvents();
        }
    }
}