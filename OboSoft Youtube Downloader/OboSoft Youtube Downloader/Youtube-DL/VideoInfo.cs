using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace OboSoft_Youtube_Downloader.Youtube_DL
{
    class VideoInfo
    {
        public string getVideoTitle(string url)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C youtube-dl --get-title " + url;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            StreamReader readoutput = process.StandardOutput;
            string video_title;
            video_title = readoutput.ReadLine();
            Console.WriteLine("Video title: " + video_title);
            return video_title;
        }

        public string getVideoExtension(string url)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C youtube-dl --get-filename " + url;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            StreamReader readoutput = process.StandardOutput;
            string video_extension;
            string video_title = getVideoTitle(url);
            string video_id = getVideoID(url);
            video_extension = readoutput.ReadLine();
            video_extension = video_extension.Replace(video_title, "");
            video_extension = video_extension.Replace("-" + video_id, "");
            Console.WriteLine("Video Extension: " + video_extension);
            return video_extension;
        }

        public string getVideoID(string url)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C youtube-dl --get-id " + url;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            StreamReader readoutput = process.StandardOutput;
            string video_id;
            video_id = readoutput.ReadLine();
            Console.WriteLine("Video ID: " + video_id);
            return video_id;
        }
    }
}
