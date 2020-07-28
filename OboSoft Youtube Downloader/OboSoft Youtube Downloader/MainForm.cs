using OboSoft_Youtube_Downloader.FFMPEG;
using OboSoft_Youtube_Downloader.GUI_Interaction;
using OboSoft_Youtube_Downloader.Youtube_DL;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private VideoInfo videoinfo = new VideoInfo();
        private VideoDownloader videoDownloader = new VideoDownloader();
        private AudioConversion audioConversion = new AudioConversion();
        private PathSelector pathSelector = new PathSelector();

        public string video_format;
        public string original_video_extension;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text) && !string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                videoDownloader.StartDownload(txtUrl.Text, txtSavePath.Text, video_format);
            }
            else
            {
                MessageBox.Show("Please enter the URL before downloading.", "URL not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            txtSavePath.Text = pathSelector.selectPath();
        }

        private void btnGetFormatList_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Contains("youtube.com") || txtUrl.Text.Contains("youtu.be"))
            {
                getFormatList(txtUrl.Text);
                txtFileName.Text = videoinfo.getVideoTitle(txtUrl.Text);
                original_video_extension = videoinfo.getVideoExtension(txtUrl.Text);
            }
            else
            {
                MessageBox.Show("Invalid URL. Please make sure you have entered a valid youtube url.");
            }
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
            }
            catch (Exception ex)
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
                if (currentLn == 1)
                {
                    listFormatList.Items.Add("Original Format");
                }
                if (currentLn == 2)
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
            if (txtFileName.Text.Equals("Leave blank for default"))
            {
                txtFileName.Clear();
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}