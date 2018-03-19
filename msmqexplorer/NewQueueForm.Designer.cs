namespace MSMQExplorer
{
    partial class NewQueueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQueueType = new System.Windows.Forms.ComboBox();
            this.textBoxQueueName = new System.Windows.Forms.TextBox();
            this.checkBoxTransactional = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.labelCreateIn = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue name:";
            // 
            // comboBoxQueueType
            // 
            this.comboBoxQueueType.AllowDrop = true;
            this.comboBoxQueueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueueType.FormattingEnabled = true;
            this.comboBoxQueueType.Items.AddRange(new object[] {
            "private$\\",
            "public$\\"});
            this.comboBoxQueueType.Location = new System.Drawing.Point(15, 71);
            this.comboBoxQueueType.Name = "comboBoxQueueType";
            this.comboBoxQueueType.Size = new System.Drawing.Size(107, 21);
            this.comboBoxQueueType.TabIndex = 1;
            // 
            // textBoxQueueName
            // 
            this.textBoxQueueName.Location = new System.Drawing.Point(129, 71);
            this.textBoxQueueName.Name = "textBoxQueueName";
            this.textBoxQueueName.Size = new System.Drawing.Size(206, 20);
            this.textBoxQueueName.TabIndex = 2;
            // 
            // checkBoxTransactional
            // 
            this.checkBoxTransactional.AutoSize = true;
            this.checkBoxTransactional.Location = new System.Drawing.Point(15, 98);
            this.checkBoxTransactional.Name = "checkBoxTransactional";
            this.checkBoxTransactional.Size = new System.Drawing.Size(90, 17);
            this.checkBoxTransactional.TabIndex = 3;
            this.checkBoxTransactional.Text = "Transactional";
            this.checkBoxTransactional.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(260, 97);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOkay
            // 
            this.buttonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkay.Location = new System.Drawing.Point(179, 97);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(75, 23);
            this.buttonOkay.TabIndex = 5;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // labelCreateIn
            // 
            this.labelCreateIn.AutoSize = true;
            this.labelCreateIn.Location = new System.Drawing.Point(13, 13);
            this.labelCreateIn.Name = "labelCreateIn";
            this.labelCreateIn.Size = new System.Drawing.Size(52, 13);
            this.labelCreateIn.TabIndex = 6;
            this.labelCreateIn.Text = "Create in:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(71, 13);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.ReadOnly = true;
            this.textBoxHost.Size = new System.Drawing.Size(264, 20);
            this.textBoxHost.TabIndex = 7;
            // 
            // NewQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 131);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.labelCreateIn);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxTransactional);
            this.Controls.Add(this.textBoxQueueName);
            this.Controls.Add(this.comboBoxQueueType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewQueueForm";
            this.Text = "New Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQueueType;
        private System.Windows.Forms.TextBox textBoxQueueName;
        private System.Windows.Forms.CheckBox checkBoxTransactional;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Label labelCreateIn;
        private System.Windows.Forms.TextBox textBoxHost;
    }
}