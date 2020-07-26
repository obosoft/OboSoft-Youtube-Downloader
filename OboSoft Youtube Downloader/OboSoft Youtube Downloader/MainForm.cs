using Microsoft.SqlServer.Server;
using OboSoft_Youtube_Downloader.FFMPEG;
using OboSoft_Youtube_Downloader.Youtube_DL;
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

        VideoInfo videoinfo = new VideoInfo();
        AudioConversion audioConversion = new AudioConversion();


        public string video_format;
        public string original_video_extension;

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
            return "%(title)s.%(ext)s";
        }

        public void downloadVideo(string url, string format)
        {
            if(!string.IsNullOrEmpty(format) || !string.IsNullOrWhiteSpace(format))
            {
                if (!string.IsNullOrEmpty(txtSavePath.Text) || !string.IsNullOrWhiteSpace(txtSavePath.Text))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C youtube-dl.exe --format " + format + " -o " + txtSavePath.Text + "/" + getOutputFileName() + " " + url;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    StreamReader sesso = process.StandardOutput;
                    Console.WriteLine(sesso.ReadToEnd());
                    sesso.Close();
                }
                else
                {
                    MessageBox.Show("Please select the save path first.", "SavePath not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (!string.IsNullOrEmpty(txtSavePath.Text) || !string.IsNullOrWhiteSpace(txtSavePath.Text))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C youtube-dl.exe -o " + txtSavePath.Text + "/" + getOutputFileName() + " " + url;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    StreamReader sesso = process.StandardOutput;
                    Console.WriteLine(sesso.ReadToEnd());
                    sesso.Close();
                    if (listFormatList.SelectedItem.Text.Equals("MP3 Audio File"))
                    {
                        audioConversion.convertToMp3(txtSavePath.Text + "/" + txtFileName.Text, videoinfo.getVideoExtension(txtUrl.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Please select the save path first.", "SavePath not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            txtFileName.Text = videoinfo.getVideoTitle(txtUrl.Text);
            original_video_extension = videoinfo.getVideoExtension(txtUrl.Text);
        }

        public void getFormatList(string url)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
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
            process.Start();
            StreamReader readoutput = process.StandardOutput;
            string ln;
            int currentLn = 0;
            while ((ln = readoutput.ReadLine()) != null)
            {
                currentLn++;
                if (currentLn > 3)
                {
                    listFormatList.Items.Add(ln + "\r\n");
                    Console.WriteLine(ln + "\r\n");
                }
                if(currentLn == 1)
                {
                    listFormatList.Items.Add("Original Format");
                }
                if(currentLn == 2)
                {
                    listFormatList.Items.Add("MP3 Audio File");
                }
            }
            //string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            btnDownload.Enabled = true;
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
           
        }

    }
}
