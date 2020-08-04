using OboSoft_Youtube_Downloader.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader.Youtube_DL
{
    internal class VideoDownloader
    {
        private VideoInfoRetriver videoInfoRetriver = new VideoInfoRetriver();

        private string[] _videoInfo;

        private string _videoTitle;
        private string _videoID;

        public void StartDownload(string url, string path, string format, string _videoExtension)
        {
            _videoInfo = videoInfoRetriver.retriveVideoInfo(url);
            _videoTitle = _videoInfo[0];
            _videoID = _videoInfo[2];

            _videoExtension = _videoExtension.Replace(" ", "");
            format = format.Replace(" ", "");

            string _videoFileName = @" """ + path + @"\" + _videoTitle + "." + _videoExtension + @"""";

            Console.WriteLine("vfm: " + _videoFileName);

            executeDownloadCmd("youtube-dl -o" + _videoFileName + " -f " + format + @" """ + url + @"""", true);
        }

        public void StartDownloadAudioOnly(string url, string path, string audio_format)
        {
            executeDownloadCmd("youtube-dl --output ", false);
        }

        public void executeDownloadCmd(string command, bool visible)
        {
            Process process = new Process();
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            Console.WriteLine("Command: " + command);
            process.StartInfo.Arguments = "/C " + @command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.CreateNoWindow = !visible;
            process.Start();
            StreamReader output = process.StandardOutput;
            if (output.ReadToEnd().Contains("ERROR"))
            {
                MessageBox.Show("Error while downloading the video: \r\n\r\nError log:\r\n" + output.ReadToEnd(), "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Download completed successfully!", "Download completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}