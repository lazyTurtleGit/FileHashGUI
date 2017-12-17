namespace FileHash
{
    partial class Form1
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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.rbMd5 = new System.Windows.Forms.RadioButton();
            this.gbHashType = new System.Windows.Forms.GroupBox();
            this.rbSha256 = new System.Windows.Forms.RadioButton();
            this.rbSha1 = new System.Windows.Forms.RadioButton();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.btnComputeHash = new System.Windows.Forms.Button();
            this.tbOutputHash = new System.Windows.Forms.TextBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.gbCompare = new System.Windows.Forms.GroupBox();
            this.btnCompareOutput = new System.Windows.Forms.Button();
            this.tbHash2Compare = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbHashType.SuspendLayout();
            this.gbFilePath.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(6, 19);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(366, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(297, 45);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // rbMd5
            // 
            this.rbMd5.AutoSize = true;
            this.rbMd5.Checked = true;
            this.rbMd5.Location = new System.Drawing.Point(6, 19);
            this.rbMd5.Name = "rbMd5";
            this.rbMd5.Size = new System.Drawing.Size(48, 17);
            this.rbMd5.TabIndex = 3;
            this.rbMd5.TabStop = true;
            this.rbMd5.Text = "MD5";
            this.rbMd5.UseVisualStyleBackColor = true;
            // 
            // gbHashType
            // 
            this.gbHashType.Controls.Add(this.rbSha256);
            this.gbHashType.Controls.Add(this.rbSha1);
            this.gbHashType.Controls.Add(this.rbMd5);
            this.gbHashType.Location = new System.Drawing.Point(12, 105);
            this.gbHashType.Name = "gbHashType";
            this.gbHashType.Size = new System.Drawing.Size(378, 43);
            this.gbHashType.TabIndex = 4;
            this.gbHashType.TabStop = false;
            this.gbHashType.Text = "Hash Type";
            // 
            // rbSha256
            // 
            this.rbSha256.AutoSize = true;
            this.rbSha256.Location = new System.Drawing.Point(141, 19);
            this.rbSha256.Name = "rbSha256";
            this.rbSha256.Size = new System.Drawing.Size(68, 17);
            this.rbSha256.TabIndex = 5;
            this.rbSha256.Text = "SHA 256";
            this.rbSha256.UseVisualStyleBackColor = true;
            // 
            // rbSha1
            // 
            this.rbSha1.AutoSize = true;
            this.rbSha1.Location = new System.Drawing.Point(70, 19);
            this.rbSha1.Name = "rbSha1";
            this.rbSha1.Size = new System.Drawing.Size(56, 17);
            this.rbSha1.TabIndex = 4;
            this.rbSha1.Text = "SHA 1";
            this.rbSha1.UseVisualStyleBackColor = true;
            // 
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.btnBrowseFile);
            this.gbFilePath.Controls.Add(this.tbFilePath);
            this.gbFilePath.Location = new System.Drawing.Point(12, 12);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Size = new System.Drawing.Size(378, 78);
            this.gbFilePath.TabIndex = 5;
            this.gbFilePath.TabStop = false;
            this.gbFilePath.Text = "File Path";
            // 
            // btnComputeHash
            // 
            this.btnComputeHash.BackColor = System.Drawing.Color.Turquoise;
            this.btnComputeHash.Location = new System.Drawing.Point(6, 19);
            this.btnComputeHash.Name = "btnComputeHash";
            this.btnComputeHash.Size = new System.Drawing.Size(366, 39);
            this.btnComputeHash.TabIndex = 6;
            this.btnComputeHash.Text = "Compute Hash";
            this.btnComputeHash.UseVisualStyleBackColor = false;
            this.btnComputeHash.Click += new System.EventHandler(this.btnComputeHash_Click);
            // 
            // tbOutputHash
            // 
            this.tbOutputHash.Location = new System.Drawing.Point(7, 64);
            this.tbOutputHash.Multiline = true;
            this.tbOutputHash.Name = "tbOutputHash";
            this.tbOutputHash.ReadOnly = true;
            this.tbOutputHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputHash.Size = new System.Drawing.Size(365, 96);
            this.tbOutputHash.TabIndex = 7;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnComputeHash);
            this.gbOutput.Controls.Add(this.tbOutputHash);
            this.gbOutput.Location = new System.Drawing.Point(12, 154);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(378, 169);
            this.gbOutput.TabIndex = 8;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output in Hex";
            // 
            // gbCompare
            // 
            this.gbCompare.Controls.Add(this.btnCompareOutput);
            this.gbCompare.Controls.Add(this.tbHash2Compare);
            this.gbCompare.Location = new System.Drawing.Point(13, 330);
            this.gbCompare.Name = "gbCompare";
            this.gbCompare.Size = new System.Drawing.Size(377, 167);
            this.gbCompare.TabIndex = 9;
            this.gbCompare.TabStop = false;
            this.gbCompare.Text = "Compare in Hex (Case does not matter)";
            // 
            // btnCompareOutput
            // 
            this.btnCompareOutput.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompareOutput.Location = new System.Drawing.Point(5, 121);
            this.btnCompareOutput.Name = "btnCompareOutput";
            this.btnCompareOutput.Size = new System.Drawing.Size(366, 39);
            this.btnCompareOutput.TabIndex = 8;
            this.btnCompareOutput.Text = "Compare with Output";
            this.btnCompareOutput.UseVisualStyleBackColor = false;
            this.btnCompareOutput.Click += new System.EventHandler(this.btnCompareOutput_Click);
            // 
            // tbHash2Compare
            // 
            this.tbHash2Compare.Location = new System.Drawing.Point(6, 19);
            this.tbHash2Compare.Multiline = true;
            this.tbHash2Compare.Name = "tbHash2Compare";
            this.tbHash2Compare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHash2Compare.Size = new System.Drawing.Size(365, 96);
            this.tbHash2Compare.TabIndex = 8;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(0, 511);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(400, 23);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(183, 515);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 534);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.gbCompare);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.gbHashType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Hash";
            this.gbHashType.ResumeLayout(false);
            this.gbHashType.PerformLayout();
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbCompare.ResumeLayout(false);
            this.gbCompare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.RadioButton rbMd5;
        private System.Windows.Forms.GroupBox gbHashType;
        private System.Windows.Forms.RadioButton rbSha256;
        private System.Windows.Forms.RadioButton rbSha1;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.Button btnComputeHash;
        private System.Windows.Forms.TextBox tbOutputHash;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbCompare;
        private System.Windows.Forms.Button btnCompareOutput;
        private System.Windows.Forms.TextBox tbHash2Compare;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblStatus;
    }
}

