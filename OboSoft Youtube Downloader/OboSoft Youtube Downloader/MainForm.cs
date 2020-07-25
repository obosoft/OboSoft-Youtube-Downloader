using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OboSoft_Youtube_Downloader
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text) && !string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                downloadVideo(txtUrl.Text);
            } else
            {
                MessageBox.Show("Please enter the URL before downloading.", "URL not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void downloadVideo(string url)
        {
            string cmdCommand;
            cmdCommand = "/C youtube-dl --format " + txtFormat.Text + " " + url;
            System.Diagnostics.Process.Start("CMD.exe", cmdCommand);
        }


    }
}
