namespace MSMQExplorer
{
    partial class ValidateResults
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxErrors = new System.Windows.Forms.GroupBox();
            this.textBoxErrors = new System.Windows.Forms.TextBox();
            this.groupBoxWarnings = new System.Windows.Forms.GroupBox();
            this.textBoxWarnings = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxErrors.SuspendLayout();
            this.groupBoxWarnings.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(65, 17);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(19, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Result:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(22, 43);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxErrors);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxWarnings);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 261);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBoxErrors
            // 
            this.groupBoxErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxErrors.Controls.Add(this.textBoxErrors);
            this.groupBoxErrors.Location = new System.Drawing.Point(3, 3);
            this.groupBoxErrors.Name = "groupBoxErrors";
            this.groupBoxErrors.Size = new System.Drawing.Size(1048, 122);
            this.groupBoxErrors.TabIndex = 4;
            this.groupBoxErrors.TabStop = false;
            this.groupBoxErrors.Text = "Errors";
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrors.Location = new System.Drawing.Point(6, 19);
            this.textBoxErrors.Multiline = true;
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxErrors.Size = new System.Drawing.Size(1036, 97);
            this.textBoxErrors.TabIndex = 3;
            // 
            // groupBoxWarnings
            // 
            this.groupBoxWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWarnings.Controls.Add(this.textBoxWarnings);
            this.groupBoxWarnings.Location = new System.Drawing.Point(3, -2);
            this.groupBoxWarnings.Name = "groupBoxWarnings";
            this.groupBoxWarnings.Size = new System.Drawing.Size(1048, 127);
            this.groupBoxWarnings.TabIndex = 5;
            this.groupBoxWarnings.TabStop = false;
            this.groupBoxWarnings.Text = "Warnings";
            // 
            // textBoxWarnings
            // 
            this.textBoxWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarnings.Location = new System.Drawing.Point(6, 13);
            this.textBoxWarnings.Multiline = true;
            this.textBoxWarnings.Name = "textBoxWarnings";
            this.textBoxWarnings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxWarnings.Size = new System.Drawing.Size(1036, 108);
            this.textBoxWarnings.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(1002, 310);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "Close";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // ValidateResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 362);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ValidateResults";
            this.Text = "Results of XSD Validation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxErrors.ResumeLayout(false);
            this.groupBoxErrors.PerformLayout();
            this.groupBoxWarnings.ResumeLayout(false);
            this.groupBoxWarnings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxErrors;
        private System.Windows.Forms.TextBox textBoxErrors;
        private System.Windows.Forms.GroupBox groupBoxWarnings;
        private System.Windows.Forms.TextBox textBoxWarnings;
        private System.Windows.Forms.Button buttonOK;
    }
}