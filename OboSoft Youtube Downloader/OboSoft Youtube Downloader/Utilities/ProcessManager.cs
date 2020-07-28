using System.Diagnostics;
using System.IO;

namespace OboSoft_Youtube_Downloader.Utilities
{
    internal class ProcessManager
    {
        public void executeCmd(string command, bool visible)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = !visible;
            process.Start();
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