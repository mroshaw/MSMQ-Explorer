#region

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace MSMQExplorer
{
    public partial class ValidateResults : Form
    {
        public ValidateResults()
        {
            InitializeComponent();
            // this.Icon = Resource.;
        }

        public ValidateResults(Boolean isValid, List<String> errors, List<String> warnings)
        {
            InitializeComponent();

            // Use non-PNG icon for Windows Server 2003 / XP
            // Icon = osVersion >= 6 ? Resource.App_Icon_48 : Resource.App_Icon_32_XP;
            Icon = Resource.MSMQ_mail_internet;
            textBoxResult.Text = isValid ? Strings.Valid : Strings.NotValid;
            textBoxWarnings.Text = string.Join(Environment.NewLine, warnings.ToArray());
            textBoxErrors.Text = string.Join(Environment.NewLine, errors.ToArray());
        }
    }
}