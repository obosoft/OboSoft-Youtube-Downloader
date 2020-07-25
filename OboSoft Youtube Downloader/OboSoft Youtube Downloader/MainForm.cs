using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OboSoft_Youtube_Downloader
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {

        public string video_format;

        public MainForm()
        {
            InitializeComponent();
        }
        
        
        private void radButton1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUrl.Text) && !string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                downloadVideo(txtUrl.Text, video_format);
            } else
            {
                MessageBox.Show("Please enter the URL before downloading.", "URL not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string getOutputFileName()
        {
            if(txtFileName.Text.Equals("Leave blank for default") || string.IsNullOrEmpty(txtFileName.Text) || string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                return "%(title)s.%(ext)s";
            }
            else
            {
                return txtFileName.Text;
            }
        }

        public void downloadVideo(string url, string format)
        {
            if(!string.IsNullOrEmpty(txtSavePath.Text) || !string.IsNullOrWhiteSpace(txtSavePath.Text))
            {

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C youtube-dl.exe --format " + format + " -o " + txtSavePath.Text + "/"  + getOutputFileName() + " " + url;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                //process.StartInfo = startInfo;
                process.Start();
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                //process.WaitForExit();
                StreamReader sesso = process.StandardOutput;
                Console.WriteLine(sesso.ReadToEnd());
                sesso.Close();

                if (format.Equals("MP3"))
                {

                }

            }
            else
            {
                MessageBox.Show("Please select the save path first.", "SavePath not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Redirect the output stream of the child process.
            

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSavePath.Text = fbd.SelectedPath.ToString();
                }
            }
        }

        private void btnGetFormatList_Click(object sender, EventArgs e)
        {
            getFormatList(txtUrl.Text);

        }

        public void getFormatList(string url)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            try
            {
                Uri uri = new Uri(url);
            } catch (Exception ex)
            {
                MessageBox.Show("Error while converting URL (Invalid URL) | " + ex.Message);
            }
                    
            process.StartInfo.Arguments = "/C youtube-dl --list-format " + url;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            //process.StartInfo = startInfo;
            process.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            //process.WaitForExit();
            // Read the output stream first and then wait.
            StreamReader readoutput = process.StandardOutput;
            string ln;
            int currentLn = 0;
            while ((ln = readoutput.ReadLine()) != null)
            {
                currentLn++;
                if (currentLn > 3)
                {

                    txtFormat.Items.Add(ln + "\r\n");
                    Console.WriteLine(ln + "\r\n");
                }
                if(currentLn == 1)
                {
                    txtFormat.Items.Add("Default");
                    txtFormat.SelectedText = "Default";
                }
                if(currentLn == 2)
                {
                    txtFormat.Items.Add("MP3");
                }
                    
            }
            //string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            btnDownload.Enabled = true;
        }

        private void txtFormat_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!txtFormat.SelectedText.Equals("Default"))
            {
                video_format = txtFormat.Text.Substring(0,3);
                video_format = video_format.Replace(" ", "");
                Console.WriteLine("Video format: " + video_format.ToString());
            } else
            {

            }
        }

        private void txtFileName_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtFileName.Text.Equals("Leave blank for default"))
            {
                txtFileName.Clear();
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFileName.Text) || string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                txtFileName.Text = "Leave blank for default";
            } else if(txtFileName.Text.Equals("Leave blank for default"))
            {
                txtFileName.Clear();
            }
        }
    }
}
