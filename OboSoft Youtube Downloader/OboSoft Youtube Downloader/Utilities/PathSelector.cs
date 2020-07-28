using System.Windows.Forms;

namespace OboSoft_Youtube_Downloader.GUI_Interaction
{
    internal class PathSelector
    {
        public string selectPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath.ToString();
                }
                return null;
            }
        }
    }
}