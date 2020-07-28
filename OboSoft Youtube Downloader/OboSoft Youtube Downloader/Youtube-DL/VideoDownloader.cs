using OboSoft_Youtube_Downloader.Utilities;
using System;
using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader.Youtube_DL
{
    internal class VideoDownloader
    {
        private ProcessManager _pm = new ProcessManager();
        private VideoInfo videoInfo = new VideoInfo();

        public void StartDownload(string url, string path, string format)
        {
            Console.WriteLine("[CMD] " + "youtube-dl --output \"" +
                path + "/" +
                videoInfo.getVideoTitle(url) +
                videoInfo.getVideoExtension(url) +
                "\" --format " + format +
                " " + url);

            _pm.executeCmd("youtube-dl --output " +
                path + "/" +
                videoInfo.getVideoTitle(url) +
                videoInfo.getVideoExtension(url) +
                " --format " + format +
                " " + url, false);
            MessageBox.Show("Download completed.");
        }

        public void StartDownloadAudioOnly(string url, string path, string audio_format)
        {
            _pm.executeCmd("youtube-dl --output ", false);
        }
    }
}