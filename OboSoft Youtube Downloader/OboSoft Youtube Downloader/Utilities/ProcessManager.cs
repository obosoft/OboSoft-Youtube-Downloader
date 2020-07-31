using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader.Utilities
{
    internal class ProcessManager
    {
        public void executeCmd(string command, bool visible)
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
            } else
            {
                MessageBox.Show("Download completed successfully!", "Download completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string executeCmdWithOutput(string command, bool visible)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = !visible;
            process.Start();
            StreamReader output = process.StandardOutput;
            string output_string = output.ReadToEnd();
            return output_string;
        }
    }
}