namespace MSMQExplorer
{
    partial class FormSettings
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
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.labelCountSeconds = new System.Windows.Forms.Label();
            this.numericUpDownRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxAutoRefreshQueues = new System.Windows.Forms.CheckBox();
            this.numericUpDownRefreshIntervalQueues = new System.Windows.Forms.NumericUpDown();
            this.labelQueueSeconds = new System.Windows.Forms.Label();
            this.checkBoxShowUpdatedTimestamp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshIntervalQueues)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(12, 12);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(183, 17);
            this.checkBoxAutoRefresh.TabIndex = 0;
            this.checkBoxAutoRefresh.Text = "Auto refresh Queue Counts every";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // labelCountSeconds
            // 
            this.labelCountSeconds.AutoSize = true;
            this.labelCountSeconds.Location = new System.Drawing.Point(256, 12);
            this.labelCountSeconds.Name = "labelCountSeconds";
            this.labelCountSeconds.Size = new System.Drawing.Size(47, 13);
            this.labelCountSeconds.TabIndex = 1;
            this.labelCountSeconds.Text = "seconds";
            // 
            // numericUpDownRefreshInterval
            // 
            this.numericUpDownRefreshInterval.Location = new System.Drawing.Point(201, 11);
            this.numericUpDownRefreshInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownRefreshInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefreshInterval.Name = "numericUpDownRefreshInterval";
            this.numericUpDownRefreshInterval.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRefreshInterval.TabIndex = 2;
            this.numericUpDownRefreshInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(228, 93);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxAutoRefreshQueues
            // 
            this.checkBoxAutoRefreshQueues.AutoSize = true;
            this.checkBoxAutoRefreshQueues.Enabled = false;
            this.checkBoxAutoRefreshQueues.Location = new System.Drawing.Point(13, 36);
            this.checkBoxAutoRefreshQueues.Name = "checkBoxAutoRefreshQueues";
            this.checkBoxAutoRefreshQueues.Size = new System.Drawing.Size(166, 17);
            this.checkBoxAutoRefreshQueues.TabIndex = 4;
            this.checkBoxAutoRefreshQueues.Text = "Auto refresh Queue List every";
            this.checkBoxAutoRefreshQueues.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRefreshIntervalQueues
            // 
            this.numericUpDownRefreshIntervalQueues.Location = new System.Drawing.Point(201, 36);
            this.numericUpDownRefreshIntervalQueues.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownRefreshIntervalQueues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRefreshIntervalQueues.Name = "numericUpDownRefreshIntervalQueues";
            this.numericUpDownRefreshIntervalQueues.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRefreshIntervalQueues.TabIndex = 5;
            this.numericUpDownRefreshIntervalQueues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQueueSeconds
            // 
            this.labelQueueSeconds.AutoSize = true;
            this.labelQueueSeconds.Location = new System.Drawing.Point(256, 36);
            this.labelQueueSeconds.Name = "labelQueueSeconds";
            this.labelQueueSeconds.Size = new System.Drawing.Size(47, 13);
            this.labelQueueSeconds.TabIndex = 6;
            this.labelQueueSeconds.Text = "seconds";
            // 
            // checkBoxShowUpdatedTimestamp
            // 
            this.checkBoxShowUpdatedTimestamp.AutoSize = true;
            this.checkBoxShowUpdatedTimestamp.Location = new System.Drawing.Point(13, 60);
            this.checkBoxShowUpdatedTimestamp.Name = "checkBoxShowUpdatedTimestamp";
            this.checkBoxShowUpdatedTimestamp.Size = new System.Drawing.Size(155, 17);
            this.checkBoxShowUpdatedTimestamp.TabIndex = 7;
            this.checkBoxShowUpdatedTimestamp.Text = "Show \"updated\" timestamp";
            this.checkBoxShowUpdatedTimestamp.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 128);
            this.Controls.Add(this.checkBoxShowUpdatedTimestamp);
            this.Controls.Add(this.labelQueueSeconds);
            this.Controls.Add(this.numericUpDownRefreshIntervalQueues);
            this.Controls.Add(this.checkBoxAutoRefreshQueues);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownRefreshInterval);
            this.Controls.Add(this.labelCountSeconds);
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshIntervalQueues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.Label labelCountSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshInterval;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxAutoRefreshQueues;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshIntervalQueues;
        private System.Windows.Forms.Label labelQueueSeconds;
        private System.Windows.Forms.CheckBox checkBoxShowUpdatedTimestamp;
    }
}