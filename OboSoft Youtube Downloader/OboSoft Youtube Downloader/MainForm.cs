using OboSoft_Youtube_Downloader.FFMPEG;
using OboSoft_Youtube_Downloader.GUI_Interaction;
using OboSoft_Youtube_Downloader.Youtube_DL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace OboSoft_Youtube_Downloader
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private VideoInfoRetriver videoInfoRetriver = new VideoInfoRetriver();
        private VideoDownloader videoDownloader = new VideoDownloader();
        private AudioConversion audioConversion = new AudioConversion();
        private PathSelector pathSelector = new PathSelector();

        public string[] _videoInfo;
        private string _videoTitle;
        private string _videoExtension;
        private string _videoID;
        private string _videoUrl;
        private string _videoSavePath;


        private string _selected_video_format;


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

                string[] sl = lvFormatList.SelectedItem.Tag.ToString().Split(char.Parse("£"));

                _selected_video_format = sl[0];
                _videoExtension = sl[1];
                Console.WriteLine("Selected format: " + _selected_video_format);
                //_selected_video_format = _selected_video_format.Replace(" ", "");
                lblDownloading.Visible = true;
                videoDownloader.StartDownload(_videoUrl, _videoSavePath, _selected_video_format, _videoExtension);
                lblDownloading.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter the URL before downloading.", "URL not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            _videoSavePath = pathSelector.selectPath();
            txtSavePath.Text = _videoSavePath;
        }

        private void btnGetFormatList_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Contains("youtube.com") || txtUrl.Text.Contains("youtu.be"))
            {
                getFormatList(txtUrl.Text);
                lblVideoTitle.Text = _videoTitle;
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
            //int currentItem = 0;
            while ((ln = readoutput.ReadLine()) != null)
            {
                currentLn++;
                if (currentLn > 3)
                {
                    if (!ln.Contains("[info]") || !ln.Contains("resolution"))
                    {
                        //if(ln.Contains("audio only"))
                        //string fId = ln.Substring(0, 3);
                        //Console.WriteLine("FormatID: " + fId);
                        //string f = ln.Substring(4, 17);
                        //f = f.Replace(" ", "");
                        //Console.WriteLine("Format: " + f);

                        //Console.WriteLine("Length = " + ln.Length);
                        //Console.WriteLine(ln.Substring(17, (ln.Length - 17)));

                        //string dex = ln.Substring(18, (ln.Length - 1));
                        //dex = dex.Replace("  ", "");

                        //lvFormatList.Items.Add()
                        ListViewDataItem item = new ListViewDataItem();
                        item.TextAlignment = ContentAlignment.MiddleCenter;
                        item.Font = new Font("Consolas", 10, FontStyle.Regular);
                        //lvFormatList.Items.Add(args[0]);
                        item.Tag = ln.Substring(0, 3);
                        item.Tag = item.Tag + "£" + ln.Substring(13, 4);
                        item.SubItems.Add(ln.Substring(0, 3)); // FORMAT ID
                        item.SubItems.Add(ln.Substring(13, 4)); // FORMAT TYPE
                        item.SubItems.Add((ln.Substring(35, 5)).Replace(" ", "")); // FORMAT RES
                        item.SubItems.Add(ln.Substring(41, (ln.Length-41))); // FORMAT TAG
                        lvFormatList.Items.Add(item);

                        //listFormatList.Items.Add("[" + ln.Substring(0, 3) + "] - " + ln.Substring(13, 4).Replace("  ", "").ToUpper() + " file - " /**+ dex*/ + "\r\n");
                        Console.WriteLine(ln + "\r\n"); ;
                        //currentItem += 1;
                    }
                }
                else if (currentLn == 1)
                {
                    ListViewDataItem item = new ListViewDataItem();
                    item.TextAlignment = ContentAlignment.MiddleCenter;
                    item.Font = new Font("Consolas", 10, FontStyle.Regular);
                    //lvFormatList.Items.Add(args[0]);
                    item.Tag = "best";
                    item.Tag = item.Tag + "£" + "mp4";
                    item.SubItems.Add("AUTO"); // FORMAT ID
                    item.SubItems.Add("ORIGINAL"); // FORMAT TYPE
                    item.SubItems.Add("BEST"); // FORMAT RES
                    item.SubItems.Add("The best video quality (ID 22)"); // FORMAT TAG
                    lvFormatList.Items.Add(item);
                }
                else if (currentLn == 2)
                {
                    listFormatList.Items.Add("020 - MP3 Audio File");
                    listFormatList.Items.Add("021 - WAV Audio File");
                }
            }
            //string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            btnDownload.Enabled = true;
            _videoInfo = videoInfoRetriver.retriveVideoInfo(url);
            _videoTitle = _videoInfo[0];
            //_videoExtension = _videoInfo[1];
            _videoID = _videoInfo[2];
            _videoUrl = _videoInfo[3];
        }

        private void txtFileName_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listFormatList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            _selected_video_format = listFormatList.SelectedItem.ToString().Substring(0, 3);
            Console.WriteLine("Video Format code: " + _selected_video_format);
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(_videoUrl) || !string.IsNullOrWhiteSpace(_videoUrl))
            {
                DialogResult result = MessageBox.Show("Do you want open \"" + _videoTitle + "\" on you web browser? \r\n\r\nFull video URL: " + _videoUrl, "External link opening", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start(_videoUrl);
                }
            }
        }
    }
}