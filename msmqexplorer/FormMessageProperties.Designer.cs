namespace MSMQExplorer
{
    partial class FormMessageProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControlMsgProperties = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.textBoxTracked = new System.Windows.Forms.TextBox();
            this.textBoxLookupId = new System.Windows.Forms.TextBox();
            this.textBoxArrived = new System.Windows.Forms.TextBox();
            this.textBoxSent = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelLookupId = new System.Windows.Forms.Label();
            this.labelTracked = new System.Windows.Forms.Label();
            this.labelArrived = new System.Windows.Forms.Label();
            this.labelSent = new System.Windows.Forms.Label();
            this.labelCass = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageQueues = new System.Windows.Forms.TabPage();
            this.groupBoxDeadLetter = new System.Windows.Forms.GroupBox();
            this.textBoxPathName = new System.Windows.Forms.TextBox();
            this.labelPathName = new System.Windows.Forms.Label();
            this.groupBoxResponse = new System.Windows.Forms.GroupBox();
            this.textBoxNameResponse = new System.Windows.Forms.TextBox();
            this.textBoxFormatNameResponse = new System.Windows.Forms.TextBox();
            this.labelNameResponse = new System.Windows.Forms.Label();
            this.labelFormatNameResponse = new System.Windows.Forms.Label();
            this.groupBoxAdminstration = new System.Windows.Forms.GroupBox();
            this.textBoxNameAdmin = new System.Windows.Forms.TextBox();
            this.textBoxFormatNameAdmin = new System.Windows.Forms.TextBox();
            this.labelNameAdmin = new System.Windows.Forms.Label();
            this.labelFormatNameAdmin = new System.Windows.Forms.Label();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.textBoxFormatNameDest = new System.Windows.Forms.TextBox();
            this.labelDestFormatName = new System.Windows.Forms.Label();
            this.groupBoxRecipient = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFormatName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFormatName = new System.Windows.Forms.Label();
            this.tabPageSender = new System.Windows.Forms.TabPage();
            this.groupBoxSecurity = new System.Windows.Forms.GroupBox();
            this.textBoxEncAlgo = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.labelEncryptAlg = new System.Windows.Forms.Label();
            this.labelEncrypted = new System.Windows.Forms.Label();
            this.groupBoxSender = new System.Windows.Forms.GroupBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.textBoxAuthenticated = new System.Windows.Forms.TextBox();
            this.labelAuth = new System.Windows.Forms.Label();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxSourceComp = new System.Windows.Forms.GroupBox();
            this.textBoxSrcName = new System.Windows.Forms.TextBox();
            this.textBoxSourceGUID = new System.Windows.Forms.TextBox();
            this.labelSrcName = new System.Windows.Forms.Label();
            this.labelSrcGUID = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabControlMsgProperties.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageQueues.SuspendLayout();
            this.groupBoxDeadLetter.SuspendLayout();
            this.groupBoxResponse.SuspendLayout();
            this.groupBoxAdminstration.SuspendLayout();
            this.groupBoxDestination.SuspendLayout();
            this.groupBoxRecipient.SuspendLayout();
            this.tabPageSender.SuspendLayout();
            this.groupBoxSecurity.SuspendLayout();
            this.groupBoxSender.SuspendLayout();
            this.groupBoxSourceComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(331, 417);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(250, 417);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // tabControlMsgProperties
            // 
            this.tabControlMsgProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMsgProperties.Controls.Add(this.tabPageGeneral);
            this.tabControlMsgProperties.Controls.Add(this.tabPageQueues);
            this.tabControlMsgProperties.Controls.Add(this.tabPageSender);
            this.tabControlMsgProperties.Location = new System.Drawing.Point(12, 13);
            this.tabControlMsgProperties.Name = "tabControlMsgProperties";
            this.tabControlMsgProperties.SelectedIndex = 0;
            this.tabControlMsgProperties.Size = new System.Drawing.Size(475, 398);
            this.tabControlMsgProperties.TabIndex = 3;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.textBoxTracked);
            this.tabPageGeneral.Controls.Add(this.textBoxLookupId);
            this.tabPageGeneral.Controls.Add(this.textBoxArrived);
            this.tabPageGeneral.Controls.Add(this.textBoxSent);
            this.tabPageGeneral.Controls.Add(this.textBoxClass);
            this.tabPageGeneral.Controls.Add(this.labelLookupId);
            this.tabPageGeneral.Controls.Add(this.labelTracked);
            this.tabPageGeneral.Controls.Add(this.labelArrived);
            this.tabPageGeneral.Controls.Add(this.labelSent);
            this.tabPageGeneral.Controls.Add(this.labelCass);
            this.tabPageGeneral.Controls.Add(this.textBoxId);
            this.tabPageGeneral.Controls.Add(this.labelId);
            this.tabPageGeneral.Controls.Add(this.textBoxLabel);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(467, 372);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // textBoxTracked
            // 
            this.textBoxTracked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTracked.Location = new System.Drawing.Point(70, 156);
            this.textBoxTracked.Name = "textBoxTracked";
            this.textBoxTracked.ReadOnly = true;
            this.textBoxTracked.Size = new System.Drawing.Size(391, 20);
            this.textBoxTracked.TabIndex = 13;
            // 
            // textBoxLookupId
            // 
            this.textBoxLookupId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLookupId.Location = new System.Drawing.Point(70, 182);
            this.textBoxLookupId.Name = "textBoxLookupId";
            this.textBoxLookupId.ReadOnly = true;
            this.textBoxLookupId.Size = new System.Drawing.Size(391, 20);
            this.textBoxLookupId.TabIndex = 12;
            // 
            // textBoxArrived
            // 
            this.textBoxArrived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrived.Location = new System.Drawing.Point(70, 130);
            this.textBoxArrived.Name = "textBoxArrived";
            this.textBoxArrived.ReadOnly = true;
            this.textBoxArrived.Size = new System.Drawing.Size(391, 20);
            this.textBoxArrived.TabIndex = 11;
            // 
            // textBoxSent
            // 
            this.textBoxSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSent.Location = new System.Drawing.Point(70, 104);
            this.textBoxSent.Name = "textBoxSent";
            this.textBoxSent.ReadOnly = true;
            this.textBoxSent.Size = new System.Drawing.Size(391, 20);
            this.textBoxSent.TabIndex = 10;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClass.Location = new System.Drawing.Point(70, 78);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(391, 20);
            this.textBoxClass.TabIndex = 9;
            // 
            // labelLookupId
            // 
            this.labelLookupId.AutoSize = true;
            this.labelLookupId.Location = new System.Drawing.Point(6, 185);
            this.labelLookupId.Name = "labelLookupId";
            this.labelLookupId.Size = new System.Drawing.Size(58, 13);
            this.labelLookupId.TabIndex = 8;
            this.labelLookupId.Text = "Lookup Id:";
            // 
            // labelTracked
            // 
            this.labelTracked.AutoSize = true;
            this.labelTracked.Location = new System.Drawing.Point(14, 159);
            this.labelTracked.Name = "labelTracked";
            this.labelTracked.Size = new System.Drawing.Size(50, 13);
            this.labelTracked.TabIndex = 7;
            this.labelTracked.Text = "Tracked:";
            // 
            // labelArrived
            // 
            this.labelArrived.AutoSize = true;
            this.labelArrived.Location = new System.Drawing.Point(21, 133);
            this.labelArrived.Name = "labelArrived";
            this.labelArrived.Size = new System.Drawing.Size(43, 13);
            this.labelArrived.TabIndex = 6;
            this.labelArrived.Text = "Arrived:";
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(32, 107);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(32, 13);
            this.labelSent.TabIndex = 5;
            this.labelSent.Text = "Sent:";
            // 
            // labelCass
            // 
            this.labelCass.AutoSize = true;
            this.labelCass.Location = new System.Drawing.Point(29, 81);
            this.labelCass.Name = "labelCass";
            this.labelCass.Size = new System.Drawing.Size(35, 13);
            this.labelCass.TabIndex = 4;
            this.labelCass.Text = "Class:";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Location = new System.Drawing.Point(70, 52);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(391, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(43, 55);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLabel.Location = new System.Drawing.Point(70, 26);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.ReadOnly = true;
            this.textBoxLabel.Size = new System.Drawing.Size(391, 20);
            this.textBoxLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label:";
            // 
            // tabPageQueues
            // 
            this.tabPageQueues.Controls.Add(this.groupBoxDeadLetter);
            this.tabPageQueues.Controls.Add(this.groupBoxResponse);
            this.tabPageQueues.Controls.Add(this.groupBoxAdminstration);
            this.tabPageQueues.Controls.Add(this.groupBoxDestination);
            this.tabPageQueues.Controls.Add(this.groupBoxRecipient);
            this.tabPageQueues.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueues.Name = "tabPageQueues";
            this.tabPageQueues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueues.Size = new System.Drawing.Size(467, 372);
            this.tabPageQueues.TabIndex = 1;
            this.tabPageQueues.Text = "Queues";
            this.tabPageQueues.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeadLetter
            // 
            this.groupBoxDeadLetter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeadLetter.Controls.Add(this.textBoxPathName);
            this.groupBoxDeadLetter.Controls.Add(this.labelPathName);
            this.groupBoxDeadLetter.Location = new System.Drawing.Point(6, 308);
            this.groupBoxDeadLetter.Name = "groupBoxDeadLetter";
            this.groupBoxDeadLetter.Size = new System.Drawing.Size(455, 52);
            this.groupBoxDeadLetter.TabIndex = 4;
            this.groupBoxDeadLetter.TabStop = false;
            this.groupBoxDeadLetter.Text = "Dead Letter";
            // 
            // textBoxPathName
            // 
            this.textBoxPathName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathName.Location = new System.Drawing.Point(87, 19);
            this.textBoxPathName.Name = "textBoxPathName";
            this.textBoxPathName.ReadOnly = true;
            this.textBoxPathName.Size = new System.Drawing.Size(362, 20);
            this.textBoxPathName.TabIndex = 6;
            // 
            // labelPathName
            // 
            this.labelPathName.AutoSize = true;
            this.labelPathName.Location = new System.Drawing.Point(8, 22);
            this.labelPathName.Name = "labelPathName";
            this.labelPathName.Size = new System.Drawing.Size(63, 13);
            this.labelPathName.TabIndex = 4;
            this.labelPathName.Text = "Path Name:";
            // 
            // groupBoxResponse
            // 
            this.groupBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResponse.Controls.Add(this.textBoxNameResponse);
            this.groupBoxResponse.Controls.Add(this.textBoxFormatNameResponse);
            this.groupBoxResponse.Controls.Add(this.labelNameResponse);
            this.groupBoxResponse.Controls.Add(this.labelFormatNameResponse);
            this.groupBoxResponse.Location = new System.Drawing.Point(6, 225);
            this.groupBoxResponse.Name = "groupBoxResponse";
            this.groupBoxResponse.Size = new System.Drawing.Size(455, 77);
            this.groupBoxResponse.TabIndex = 3;
            this.groupBoxResponse.TabStop = false;
            this.groupBoxResponse.Text = "Response";
            // 
            // textBoxNameResponse
            // 
            this.textBoxNameResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameResponse.Location = new System.Drawing.Point(87, 46);
            this.textBoxNameResponse.Name = "textBoxNameResponse";
            this.textBoxNameResponse.ReadOnly = true;
            this.textBoxNameResponse.Size = new System.Drawing.Size(362, 20);
            this.textBoxNameResponse.TabIndex = 7;
            // 
            // textBoxFormatNameResponse
            // 
            this.textBoxFormatNameResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormatNameResponse.Location = new System.Drawing.Point(87, 19);
            this.textBoxFormatNameResponse.Name = "textBoxFormatNameResponse";
            this.textBoxFormatNameResponse.ReadOnly = true;
            this.textBoxFormatNameResponse.Size = new System.Drawing.Size(362, 20);
            this.textBoxFormatNameResponse.TabIndex = 6;
            // 
            // labelNameResponse
            // 
            this.labelNameResponse.AutoSize = true;
            this.labelNameResponse.Location = new System.Drawing.Point(43, 49);
            this.labelNameResponse.Name = "labelNameResponse";
            this.labelNameResponse.Size = new System.Drawing.Size(38, 13);
            this.labelNameResponse.TabIndex = 5;
            this.labelNameResponse.Text = "Name:";
            // 
            // labelFormatNameResponse
            // 
            this.labelFormatNameResponse.AutoSize = true;
            this.labelFormatNameResponse.Location = new System.Drawing.Point(8, 22);
            this.labelFormatNameResponse.Name = "labelFormatNameResponse";
            this.labelFormatNameResponse.Size = new System.Drawing.Size(73, 13);
            this.labelFormatNameResponse.TabIndex = 4;
            this.labelFormatNameResponse.Text = "Format Name:";
            // 
            // groupBoxAdminstration
            // 
            this.groupBoxAdminstration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdminstration.Controls.Add(this.textBoxNameAdmin);
            this.groupBoxAdminstration.Controls.Add(this.textBoxFormatNameAdmin);
            this.groupBoxAdminstration.Controls.Add(this.labelNameAdmin);
            this.groupBoxAdminstration.Controls.Add(this.labelFormatNameAdmin);
            this.groupBoxAdminstration.Location = new System.Drawing.Point(6, 142);
            this.groupBoxAdminstration.Name = "groupBoxAdminstration";
            this.groupBoxAdminstration.Size = new System.Drawing.Size(455, 77);
            this.groupBoxAdminstration.TabIndex = 2;
            this.groupBoxAdminstration.TabStop = false;
            this.groupBoxAdminstration.Text = "Administration";
            // 
            // textBoxNameAdmin
            // 
            this.textBoxNameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameAdmin.Location = new System.Drawing.Point(87, 46);
            this.textBoxNameAdmin.Name = "textBoxNameAdmin";
            this.textBoxNameAdmin.ReadOnly = true;
            this.textBoxNameAdmin.Size = new System.Drawing.Size(362, 20);
            this.textBoxNameAdmin.TabIndex = 7;
            // 
            // textBoxFormatNameAdmin
            // 
            this.textBoxFormatNameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormatNameAdmin.Location = new System.Drawing.Point(87, 19);
            this.textBoxFormatNameAdmin.Name = "textBoxFormatNameAdmin";
            this.textBoxFormatNameAdmin.ReadOnly = true;
            this.textBoxFormatNameAdmin.Size = new System.Drawing.Size(362, 20);
            this.textBoxFormatNameAdmin.TabIndex = 6;
            // 
            // labelNameAdmin
            // 
            this.labelNameAdmin.AutoSize = true;
            this.labelNameAdmin.Location = new System.Drawing.Point(43, 49);
            this.labelNameAdmin.Name = "labelNameAdmin";
            this.labelNameAdmin.Size = new System.Drawing.Size(38, 13);
            this.labelNameAdmin.TabIndex = 5;
            this.labelNameAdmin.Text = "Name:";
            // 
            // labelFormatNameAdmin
            // 
            this.labelFormatNameAdmin.AutoSize = true;
            this.labelFormatNameAdmin.Location = new System.Drawing.Point(8, 22);
            this.labelFormatNameAdmin.Name = "labelFormatNameAdmin";
            this.labelFormatNameAdmin.Size = new System.Drawing.Size(73, 13);
            this.labelFormatNameAdmin.TabIndex = 4;
            this.labelFormatNameAdmin.Text = "Format Name:";
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDestination.Controls.Add(this.textBoxFormatNameDest);
            this.groupBoxDestination.Controls.Add(this.labelDestFormatName);
            this.groupBoxDestination.Location = new System.Drawing.Point(7, 86);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(454, 50);
            this.groupBoxDestination.TabIndex = 1;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Destination";
            // 
            // textBoxFormatNameDest
            // 
            this.textBoxFormatNameDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormatNameDest.Location = new System.Drawing.Point(86, 20);
            this.textBoxFormatNameDest.Name = "textBoxFormatNameDest";
            this.textBoxFormatNameDest.ReadOnly = true;
            this.textBoxFormatNameDest.Size = new System.Drawing.Size(362, 20);
            this.textBoxFormatNameDest.TabIndex = 1;
            // 
            // labelDestFormatName
            // 
            this.labelDestFormatName.AutoSize = true;
            this.labelDestFormatName.Location = new System.Drawing.Point(10, 20);
            this.labelDestFormatName.Name = "labelDestFormatName";
            this.labelDestFormatName.Size = new System.Drawing.Size(73, 13);
            this.labelDestFormatName.TabIndex = 0;
            this.labelDestFormatName.Text = "Format Name:";
            // 
            // groupBoxRecipient
            // 
            this.groupBoxRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecipient.Controls.Add(this.textBoxName);
            this.groupBoxRecipient.Controls.Add(this.textBoxFormatName);
            this.groupBoxRecipient.Controls.Add(this.labelName);
            this.groupBoxRecipient.Controls.Add(this.labelFormatName);
            this.groupBoxRecipient.Location = new System.Drawing.Point(7, 7);
            this.groupBoxRecipient.Name = "groupBoxRecipient";
            this.groupBoxRecipient.Size = new System.Drawing.Size(454, 73);
            this.groupBoxRecipient.TabIndex = 0;
            this.groupBoxRecipient.TabStop = false;
            this.groupBoxRecipient.Text = "Recipient";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(86, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(362, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxFormatName
            // 
            this.textBoxFormatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormatName.Location = new System.Drawing.Point(86, 17);
            this.textBoxFormatName.Name = "textBoxFormatName";
            this.textBoxFormatName.ReadOnly = true;
            this.textBoxFormatName.Size = new System.Drawing.Size(362, 20);
            this.textBoxFormatName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelFormatName
            // 
            this.labelFormatName.AutoSize = true;
            this.labelFormatName.Location = new System.Drawing.Point(7, 20);
            this.labelFormatName.Name = "labelFormatName";
            this.labelFormatName.Size = new System.Drawing.Size(73, 13);
            this.labelFormatName.TabIndex = 0;
            this.labelFormatName.Text = "Format Name:";
            // 
            // tabPageSender
            // 
            this.tabPageSender.Controls.Add(this.groupBoxSecurity);
            this.tabPageSender.Controls.Add(this.groupBoxSender);
            this.tabPageSender.Controls.Add(this.groupBoxSourceComp);
            this.tabPageSender.Location = new System.Drawing.Point(4, 22);
            this.tabPageSender.Name = "tabPageSender";
            this.tabPageSender.Size = new System.Drawing.Size(467, 372);
            this.tabPageSender.TabIndex = 2;
            this.tabPageSender.Text = "Sender";
            this.tabPageSender.UseVisualStyleBackColor = true;
            // 
            // groupBoxSecurity
            // 
            this.groupBoxSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSecurity.Controls.Add(this.textBoxEncAlgo);
            this.groupBoxSecurity.Controls.Add(this.textBoxEncrypted);
            this.groupBoxSecurity.Controls.Add(this.labelEncryptAlg);
            this.groupBoxSecurity.Controls.Add(this.labelEncrypted);
            this.groupBoxSecurity.Location = new System.Drawing.Point(7, 224);
            this.groupBoxSecurity.Name = "groupBoxSecurity";
            this.groupBoxSecurity.Size = new System.Drawing.Size(457, 85);
            this.groupBoxSecurity.TabIndex = 2;
            this.groupBoxSecurity.TabStop = false;
            this.groupBoxSecurity.Text = "Security";
            // 
            // textBoxEncAlgo
            // 
            this.textBoxEncAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEncAlgo.Location = new System.Drawing.Point(152, 50);
            this.textBoxEncAlgo.Name = "textBoxEncAlgo";
            this.textBoxEncAlgo.ReadOnly = true;
            this.textBoxEncAlgo.Size = new System.Drawing.Size(295, 20);
            this.textBoxEncAlgo.TabIndex = 7;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEncrypted.Location = new System.Drawing.Point(152, 23);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.ReadOnly = true;
            this.textBoxEncrypted.Size = new System.Drawing.Size(295, 20);
            this.textBoxEncrypted.TabIndex = 6;
            // 
            // labelEncryptAlg
            // 
            this.labelEncryptAlg.AutoSize = true;
            this.labelEncryptAlg.Location = new System.Drawing.Point(41, 53);
            this.labelEncryptAlg.Name = "labelEncryptAlg";
            this.labelEncryptAlg.Size = new System.Drawing.Size(105, 13);
            this.labelEncryptAlg.TabIndex = 5;
            this.labelEncryptAlg.Text = "Encryption algorithm:";
            // 
            // labelEncrypted
            // 
            this.labelEncrypted.AutoSize = true;
            this.labelEncrypted.Location = new System.Drawing.Point(42, 26);
            this.labelEncrypted.Name = "labelEncrypted";
            this.labelEncrypted.Size = new System.Drawing.Size(58, 13);
            this.labelEncrypted.TabIndex = 4;
            this.labelEncrypted.Text = "Encrypted:";
            // 
            // groupBoxSender
            // 
            this.groupBoxSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSender.Controls.Add(this.textBoxHash);
            this.groupBoxSender.Controls.Add(this.labelHash);
            this.groupBoxSender.Controls.Add(this.textBoxAuthenticated);
            this.groupBoxSender.Controls.Add(this.labelAuth);
            this.groupBoxSender.Controls.Add(this.textBoxSID);
            this.groupBoxSender.Controls.Add(this.textBoxUser);
            this.groupBoxSender.Controls.Add(this.labelSID);
            this.groupBoxSender.Controls.Add(this.labelUser);
            this.groupBoxSender.Location = new System.Drawing.Point(7, 113);
            this.groupBoxSender.Name = "groupBoxSender";
            this.groupBoxSender.Size = new System.Drawing.Size(457, 105);
            this.groupBoxSender.TabIndex = 1;
            this.groupBoxSender.TabStop = false;
            this.groupBoxSender.Text = "Sender";
            // 
            // textBoxHash
            // 
            this.textBoxHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHash.Location = new System.Drawing.Point(288, 76);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.ReadOnly = true;
            this.textBoxHash.Size = new System.Drawing.Size(159, 20);
            this.textBoxHash.TabIndex = 11;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(201, 79);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(81, 13);
            this.labelHash.TabIndex = 10;
            this.labelHash.Text = "Hash Algorithm:";
            // 
            // textBoxAuthenticated
            // 
            this.textBoxAuthenticated.Location = new System.Drawing.Point(85, 76);
            this.textBoxAuthenticated.Name = "textBoxAuthenticated";
            this.textBoxAuthenticated.ReadOnly = true;
            this.textBoxAuthenticated.Size = new System.Drawing.Size(95, 20);
            this.textBoxAuthenticated.TabIndex = 9;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Location = new System.Drawing.Point(3, 79);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(76, 13);
            this.labelAuth.TabIndex = 8;
            this.labelAuth.Text = "Authenticated:";
            // 
            // textBoxSID
            // 
            this.textBoxSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSID.Location = new System.Drawing.Point(85, 50);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.ReadOnly = true;
            this.textBoxSID.Size = new System.Drawing.Size(362, 20);
            this.textBoxSID.TabIndex = 7;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.Location = new System.Drawing.Point(85, 23);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(362, 20);
            this.textBoxUser.TabIndex = 6;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Location = new System.Drawing.Point(51, 53);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(28, 13);
            this.labelSID.TabIndex = 5;
            this.labelSID.Text = "SID:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(47, 26);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "User:";
            // 
            // groupBoxSourceComp
            // 
            this.groupBoxSourceComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSourceComp.Controls.Add(this.textBoxSrcName);
            this.groupBoxSourceComp.Controls.Add(this.textBoxSourceGUID);
            this.groupBoxSourceComp.Controls.Add(this.labelSrcName);
            this.groupBoxSourceComp.Controls.Add(this.labelSrcGUID);
            this.groupBoxSourceComp.Location = new System.Drawing.Point(7, 7);
            this.groupBoxSourceComp.Name = "groupBoxSourceComp";
            this.groupBoxSourceComp.Size = new System.Drawing.Size(457, 100);
            this.groupBoxSourceComp.TabIndex = 0;
            this.groupBoxSourceComp.TabStop = false;
            this.groupBoxSourceComp.Text = "Source Computer";
            // 
            // textBoxSrcName
            // 
            this.textBoxSrcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSrcName.Location = new System.Drawing.Point(85, 23);
            this.textBoxSrcName.Name = "textBoxSrcName";
            this.textBoxSrcName.ReadOnly = true;
            this.textBoxSrcName.Size = new System.Drawing.Size(362, 20);
            this.textBoxSrcName.TabIndex = 7;
            // 
            // textBoxSourceGUID
            // 
            this.textBoxSourceGUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceGUID.Location = new System.Drawing.Point(85, 49);
            this.textBoxSourceGUID.Name = "textBoxSourceGUID";
            this.textBoxSourceGUID.ReadOnly = true;
            this.textBoxSourceGUID.Size = new System.Drawing.Size(362, 20);
            this.textBoxSourceGUID.TabIndex = 6;
            this.textBoxSourceGUID.Visible = false;
            // 
            // labelSrcName
            // 
            this.labelSrcName.AutoSize = true;
            this.labelSrcName.Location = new System.Drawing.Point(42, 26);
            this.labelSrcName.Name = "labelSrcName";
            this.labelSrcName.Size = new System.Drawing.Size(38, 13);
            this.labelSrcName.TabIndex = 5;
            this.labelSrcName.Text = "Name:";
            // 
            // labelSrcGUID
            // 
            this.labelSrcGUID.AutoSize = true;
            this.labelSrcGUID.Location = new System.Drawing.Point(43, 52);
            this.labelSrcGUID.Name = "labelSrcGUID";
            this.labelSrcGUID.Size = new System.Drawing.Size(37, 13);
            this.labelSrcGUID.TabIndex = 4;
            this.labelSrcGUID.Text = "GUID:";
            this.labelSrcGUID.Visible = false;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(412, 417);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // FormMessageProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 452);
            this.Controls.Add(this.tabControlMsgProperties);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMessageProperties";
            this.Text = "Message Properties";
            this.tabControlMsgProperties.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageQueues.ResumeLayout(false);
            this.groupBoxDeadLetter.ResumeLayout(false);
            this.groupBoxDeadLetter.PerformLayout();
            this.groupBoxResponse.ResumeLayout(false);
            this.groupBoxResponse.PerformLayout();
            this.groupBoxAdminstration.ResumeLayout(false);
            this.groupBoxAdminstration.PerformLayout();
            this.groupBoxDestination.ResumeLayout(false);
            this.groupBoxDestination.PerformLayout();
            this.groupBoxRecipient.ResumeLayout(false);
            this.groupBoxRecipient.PerformLayout();
            this.tabPageSender.ResumeLayout(false);
            this.groupBoxSecurity.ResumeLayout(false);
            this.groupBoxSecurity.PerformLayout();
            this.groupBoxSender.ResumeLayout(false);
            this.groupBoxSender.PerformLayout();
            this.groupBoxSourceComp.ResumeLayout(false);
            this.groupBoxSourceComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControlMsgProperties;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageQueues;
        private System.Windows.Forms.TabPage tabPageSender;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxTracked;
        private System.Windows.Forms.TextBox textBoxLookupId;
        private System.Windows.Forms.TextBox textBoxArrived;
        private System.Windows.Forms.TextBox textBoxSent;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label labelLookupId;
        private System.Windows.Forms.Label labelTracked;
        private System.Windows.Forms.Label labelArrived;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Label labelCass;
        private System.Windows.Forms.GroupBox groupBoxDeadLetter;
        private System.Windows.Forms.TextBox textBoxPathName;
        private System.Windows.Forms.Label labelPathName;
        private System.Windows.Forms.GroupBox groupBoxResponse;
        private System.Windows.Forms.TextBox textBoxNameResponse;
        private System.Windows.Forms.TextBox textBoxFormatNameResponse;
        private System.Windows.Forms.Label labelNameResponse;
        private System.Windows.Forms.Label labelFormatNameResponse;
        private System.Windows.Forms.GroupBox groupBoxAdminstration;
        private System.Windows.Forms.TextBox textBoxNameAdmin;
        private System.Windows.Forms.TextBox textBoxFormatNameAdmin;
        private System.Windows.Forms.Label labelNameAdmin;
        private System.Windows.Forms.Label labelFormatNameAdmin;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.TextBox textBoxFormatNameDest;
        private System.Windows.Forms.Label labelDestFormatName;
        private System.Windows.Forms.GroupBox groupBoxRecipient;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFormatName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFormatName;
        private System.Windows.Forms.GroupBox groupBoxSecurity;
        private System.Windows.Forms.TextBox textBoxEncAlgo;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Label labelEncryptAlg;
        private System.Windows.Forms.Label labelEncrypted;
        private System.Windows.Forms.GroupBox groupBoxSender;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox textBoxAuthenticated;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxSourceComp;
        private System.Windows.Forms.TextBox textBoxSrcName;
        private System.Windows.Forms.TextBox textBoxSourceGUID;
        private System.Windows.Forms.Label labelSrcName;
        private System.Windows.Forms.Label labelSrcGUID;
    }
}