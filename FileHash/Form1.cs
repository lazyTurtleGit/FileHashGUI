using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHash
{
    public partial class Form1 : Form
    {
        private void initFilePath()
        {
            tbFilePath.Text = String.Empty;
        }

        private void initHashType()
        {
            rbMd5.Checked = true;
        }

        private void initOutput()
        {
            tbOutputHash.Text = String.Empty;
        }

        private void initCompare()
        {
            tbHash2Compare.Text = String.Empty;
        }

        private void initForm()
        {

            initFilePath();

            initHashType();

            initOutput();

            initCompare();

            setStatus(StatusForm.Ready);
        }

        public Form1()
        {
            InitializeComponent();

            initForm();
        }

        private void showError(string errorMsg)
        {
            if (errorMsg.Length > 0)
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private enum StatusForm
        {
            Busy,
            Ready
        }

        private void setStatus(StatusForm thisFormStatus)
        {
            switch(thisFormStatus)
            {
                case StatusForm.Busy:
                    gbFilePath.Enabled = false;
                    gbHashType.Enabled = false;
                    gbOutput.Enabled = false;
                    gbCompare.Enabled = false;
                    pbProgress.Style = ProgressBarStyle.Marquee;
                    lblStatus.Text = "Busy..";

                    break;
                case StatusForm.Ready:
                    gbFilePath.Enabled = true;
                    gbHashType.Enabled = true;
                    gbOutput.Enabled = true;
                    gbCompare.Enabled = true;
                    pbProgress.Style = ProgressBarStyle.Continuous;
                    lblStatus.Text = "Ready";
                    break;
                default:
                    break;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog l_fileDialog = new OpenFileDialog();
            DialogResult result = l_fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string l_file = l_fileDialog.FileName;
                tbFilePath.Text = l_file;
            }
            else
            {
                showError("An error ocurred while trying to retrieve file.");
            }
        }

        private async void btnComputeHash_Click(object sender, EventArgs e)
        {
            //check inputs
            if(String.IsNullOrEmpty(tbFilePath.Text))
            {
                showError("Please specify a file.");
                return;
            }

            if (!File.Exists(tbFilePath.Text))
            {
                showError("Please specify a valid file path.");
                return;
            }

            byte[] l_output = new byte[1];

            //update form status
            setStatus(StatusForm.Busy);

            Crypto l_crypto = new Crypto();

            //CPU bound, hence run in background
            await Task.Run
            (
                () =>
                {
                    //md5
                    if(rbMd5.Checked)
                    {
                        if(!l_crypto.ComputeMD5(tbFilePath.Text, ref l_output))
                        {
                            showError("Hash failed.");
                            return;
                        }
                    }
                    //sha1
                    else if (rbSha1.Checked)
                    {
                        if (!l_crypto.ComputeSHA1(tbFilePath.Text, ref l_output))
                        {
                            showError("Hash failed.");
                            return;
                        }
                    }

                    //sha256
                    else if (rbSha256.Checked)
                    {
                        if (!l_crypto.ComputeSHA256(tbFilePath.Text, ref l_output))
                        {
                            showError("Hash failed.");
                            return;
                        }
                    }
                    //invalid type
                    else
                    {
                        showError("Invalid hash type.");
                        return;
                    }
                }
            );

            //update form status
            setStatus(StatusForm.Ready);

            tbOutputHash.Text = BitConverter.ToString(l_output).Replace("-", "").ToUpper();
        }

        private void btnCompareOutput_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbOutputHash.Text))
            {
                showError("Make sure you have already generated a hash above, before proceeeding with comparison.");
                return;
            }
            if(String.IsNullOrEmpty(tbHash2Compare.Text))
            {
                showError("Please make sure there is a hash string to be compared.");
                return;
            }

            string l_hash2Compare = tbHash2Compare.Text.ToUpper();
            string l_previousOutput = tbOutputHash.Text.ToUpper();

            //different
            if(String.Compare(l_hash2Compare, l_previousOutput) != 0)
            {
                MessageBox.Show("The hashes are DIFFERENT!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //same
            else 
            {
                MessageBox.Show("The hashes are SAME!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
