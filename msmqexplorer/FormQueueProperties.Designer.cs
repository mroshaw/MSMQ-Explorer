namespace MSMQExplorer
{
    partial class FormQueueProperties
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
            this.labelQueueName = new System.Windows.Forms.Label();
            this.textBoxQueueName = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.labelTypeId = new System.Windows.Forms.Label();
            this.textBoxTypeId = new System.Windows.Forms.TextBox();
            this.checkBoxLimitStorage = new System.Windows.Forms.CheckBox();
            this.numericUpDownQueueLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAuthenticated = new System.Windows.Forms.CheckBox();
            this.labelPrivacy = new System.Windows.Forms.Label();
            this.comboBoxPrivacyLevel = new System.Windows.Forms.ComboBox();
            this.groupBoxJournal = new System.Windows.Forms.GroupBox();
            this.checkBoxLimitJournalStorage = new System.Windows.Forms.CheckBox();
            this.checkBoxJournalEnabled = new System.Windows.Forms.CheckBox();
            this.numericUpDownJournalLimit = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueLimit)).BeginInit();
            this.groupBoxJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJournalLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQueueName
            // 
            this.labelQueueName.AutoSize = true;
            this.labelQueueName.Location = new System.Drawing.Point(17, 12);
            this.labelQueueName.Name = "labelQueueName";
            this.labelQueueName.Size = new System.Drawing.Size(38, 13);
            this.labelQueueName.TabIndex = 0;
            this.labelQueueName.Text = "Name:";
            // 
            // textBoxQueueName
            // 
            this.textBoxQueueName.Enabled = false;
            this.textBoxQueueName.Location = new System.Drawing.Point(92, 12);
            this.textBoxQueueName.Name = "textBoxQueueName";
            this.textBoxQueueName.Size = new System.Drawing.Size(219, 20);
            this.textBoxQueueName.TabIndex = 1;
            this.textBoxQueueName.TextChanged += new System.EventHandler(this.textBoxQueueName_TextChanged);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Location = new System.Drawing.Point(17, 43);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(36, 13);
            this.labelLabel.TabIndex = 2;
            this.labelLabel.Text = "Label:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(92, 38);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(219, 20);
            this.textBoxLabel.TabIndex = 3;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // labelTypeId
            // 
            this.labelTypeId.AutoSize = true;
            this.labelTypeId.Location = new System.Drawing.Point(17, 67);
            this.labelTypeId.Name = "labelTypeId";
            this.labelTypeId.Size = new System.Drawing.Size(48, 13);
            this.labelTypeId.TabIndex = 4;
            this.labelTypeId.Text = "Type ID:";
            // 
            // textBoxTypeId
            // 
            this.textBoxTypeId.Enabled = false;
            this.textBoxTypeId.Location = new System.Drawing.Point(92, 64);
            this.textBoxTypeId.Name = "textBoxTypeId";
            this.textBoxTypeId.Size = new System.Drawing.Size(219, 20);
            this.textBoxTypeId.TabIndex = 5;
            this.textBoxTypeId.TextChanged += new System.EventHandler(this.textBoxTypeId_TextChanged);
            // 
            // checkBoxLimitStorage
            // 
            this.checkBoxLimitStorage.AutoSize = true;
            this.checkBoxLimitStorage.Location = new System.Drawing.Point(92, 91);
            this.checkBoxLimitStorage.Name = "checkBoxLimitStorage";
            this.checkBoxLimitStorage.Size = new System.Drawing.Size(168, 17);
            this.checkBoxLimitStorage.TabIndex = 6;
            this.checkBoxLimitStorage.Text = "Limit message storage to (KB):";
            this.checkBoxLimitStorage.UseVisualStyleBackColor = true;
            this.checkBoxLimitStorage.CheckedChanged += new System.EventHandler(this.checkBoxLimitStorage_CheckedChanged);
            // 
            // numericUpDownQueueLimit
            // 
            this.numericUpDownQueueLimit.Location = new System.Drawing.Point(266, 91);
            this.numericUpDownQueueLimit.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownQueueLimit.Name = "numericUpDownQueueLimit";
            this.numericUpDownQueueLimit.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownQueueLimit.TabIndex = 7;
            this.numericUpDownQueueLimit.ValueChanged += new System.EventHandler(this.numericUpDownQueueLimit_ValueChanged);
            // 
            // checkBoxAuthenticated
            // 
            this.checkBoxAuthenticated.AutoSize = true;
            this.checkBoxAuthenticated.Location = new System.Drawing.Point(92, 115);
            this.checkBoxAuthenticated.Name = "checkBoxAuthenticated";
            this.checkBoxAuthenticated.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAuthenticated.TabIndex = 8;
            this.checkBoxAuthenticated.Text = "Authenticated";
            this.checkBoxAuthenticated.UseVisualStyleBackColor = true;
            this.checkBoxAuthenticated.CheckedChanged += new System.EventHandler(this.checkBoxAuthenticated_CheckedChanged);
            // 
            // labelPrivacy
            // 
            this.labelPrivacy.AutoSize = true;
            this.labelPrivacy.Location = new System.Drawing.Point(17, 144);
            this.labelPrivacy.Name = "labelPrivacy";
            this.labelPrivacy.Size = new System.Drawing.Size(74, 13);
            this.labelPrivacy.TabIndex = 9;
            this.labelPrivacy.Text = "Privacy Level:";
            // 
            // comboBoxPrivacyLevel
            // 
            this.comboBoxPrivacyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacyLevel.FormattingEnabled = true;
            this.comboBoxPrivacyLevel.Items.AddRange(new object[] {
            "None",
            "Optional",
            "Body"});
            this.comboBoxPrivacyLevel.Location = new System.Drawing.Point(92, 141);
            this.comboBoxPrivacyLevel.Name = "comboBoxPrivacyLevel";
            this.comboBoxPrivacyLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrivacyLevel.TabIndex = 10;
            this.comboBoxPrivacyLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrivacyLevel_SelectedIndexChanged);
            // 
            // groupBoxJournal
            // 
            this.groupBoxJournal.Controls.Add(this.checkBoxLimitJournalStorage);
            this.groupBoxJournal.Controls.Add(this.checkBoxJournalEnabled);
            this.groupBoxJournal.Location = new System.Drawing.Point(20, 168);
            this.groupBoxJournal.Name = "groupBoxJournal";
            this.groupBoxJournal.Size = new System.Drawing.Size(304, 72);
            this.groupBoxJournal.TabIndex = 11;
            this.groupBoxJournal.TabStop = false;
            this.groupBoxJournal.Text = "Journal";
            // 
            // checkBoxLimitJournalStorage
            // 
            this.checkBoxLimitJournalStorage.AutoSize = true;
            this.checkBoxLimitJournalStorage.Location = new System.Drawing.Point(7, 44);
            this.checkBoxLimitJournalStorage.Name = "checkBoxLimitJournalStorage";
            this.checkBoxLimitJournalStorage.Size = new System.Drawing.Size(157, 17);
            this.checkBoxLimitJournalStorage.TabIndex = 1;
            this.checkBoxLimitJournalStorage.Text = "Limit journal storage to (KB):";
            this.checkBoxLimitJournalStorage.UseVisualStyleBackColor = true;
            this.checkBoxLimitJournalStorage.CheckedChanged += new System.EventHandler(this.checkBoxLimitJournalStorage_CheckedChanged);
            // 
            // checkBoxJournalEnabled
            // 
            this.checkBoxJournalEnabled.AutoSize = true;
            this.checkBoxJournalEnabled.Location = new System.Drawing.Point(7, 20);
            this.checkBoxJournalEnabled.Name = "checkBoxJournalEnabled";
            this.checkBoxJournalEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxJournalEnabled.TabIndex = 0;
            this.checkBoxJournalEnabled.Text = "Enabled";
            this.checkBoxJournalEnabled.UseVisualStyleBackColor = true;
            this.checkBoxJournalEnabled.CheckedChanged += new System.EventHandler(this.checkBoxJournalEnabled_CheckedChanged);
            // 
            // numericUpDownJournalLimit
            // 
            this.numericUpDownJournalLimit.Location = new System.Drawing.Point(266, 209);
            this.numericUpDownJournalLimit.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDownJournalLimit.Name = "numericUpDownJournalLimit";
            this.numericUpDownJournalLimit.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownJournalLimit.TabIndex = 2;
            this.numericUpDownJournalLimit.ValueChanged += new System.EventHandler(this.numericUpDownJournalLimit_ValueChanged);
            this.numericUpDownJournalLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownJournalLimit_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(156, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOkay
            // 
            this.buttonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkay.Location = new System.Drawing.Point(75, 247);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(75, 23);
            this.buttonOkay.TabIndex = 13;
            this.buttonOkay.Text = "OK";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(237, 247);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 14;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormQueueProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 280);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownJournalLimit);
            this.Controls.Add(this.groupBoxJournal);
            this.Controls.Add(this.comboBoxPrivacyLevel);
            this.Controls.Add(this.labelPrivacy);
            this.Controls.Add(this.checkBoxAuthenticated);
            this.Controls.Add(this.numericUpDownQueueLimit);
            this.Controls.Add(this.checkBoxLimitStorage);
            this.Controls.Add(this.textBoxTypeId);
            this.Controls.Add(this.labelTypeId);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.textBoxQueueName);
            this.Controls.Add(this.labelQueueName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormQueueProperties";
            this.Text = "Queue Properties";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueueLimit)).EndInit();
            this.groupBoxJournal.ResumeLayout(false);
            this.groupBoxJournal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJournalLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQueueName;
        private System.Windows.Forms.TextBox textBoxQueueName;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label labelTypeId;
        private System.Windows.Forms.TextBox textBoxTypeId;
        private System.Windows.Forms.CheckBox checkBoxLimitStorage;
        private System.Windows.Forms.NumericUpDown numericUpDownQueueLimit;
        private System.Windows.Forms.CheckBox checkBoxAuthenticated;
        private System.Windows.Forms.Label labelPrivacy;
        private System.Windows.Forms.ComboBox comboBoxPrivacyLevel;
        private System.Windows.Forms.GroupBox groupBoxJournal;
        private System.Windows.Forms.CheckBox checkBoxJournalEnabled;
        private System.Windows.Forms.CheckBox checkBoxLimitJournalStorage;
        private System.Windows.Forms.NumericUpDown numericUpDownJournalLimit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Button buttonApply;
    }
}