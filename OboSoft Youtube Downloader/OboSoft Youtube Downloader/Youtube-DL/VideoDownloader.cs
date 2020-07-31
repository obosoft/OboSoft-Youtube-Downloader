using OboSoft_Youtube_Downloader.Utilities;
using System;
using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader.Youtube_DL
{
    internal class VideoDownloader
    {
        private ProcessManager _pm = new ProcessManager();
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

            _pm.executeCmd("youtube-dl -o" + _videoFileName + " -f " + format + @" """ + url + @"""", true);
        }

        public void StartDownloadAudioOnly(string url, string path, string audio_format)
        {
            _pm.executeCmd("youtube-dl --output ", false);
        }
    }
}