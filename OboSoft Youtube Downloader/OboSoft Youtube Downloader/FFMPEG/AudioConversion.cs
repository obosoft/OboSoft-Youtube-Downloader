using System;
using System.Diagnostics;
using System.IO;

namespace OboSoft_Youtube_Downloader.FFMPEG
{
    internal class AudioConversion
    {
        public void convertToMp3(string filepath, string ext)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C ffmpeg -i \"" + filepath + ext + "\" " + filepath + "[1]" + ".mp3";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            StreamReader readoutput = process.StandardOutput;
            string video_title;
            while ((video_title = readoutput.ReadLine()) != null)
                Console.WriteLine("[FFMPEG] " + video_title);
        }
    }
}