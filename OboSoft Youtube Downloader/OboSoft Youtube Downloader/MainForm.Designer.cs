namespace OboSoft_Youtube_Downloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.txtUrl = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnDownload = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtSavePath = new Telerik.WinControls.UI.RadTextBox();
            this.btnSelectPath = new Telerik.WinControls.UI.RadButton();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.btnGetFormatList = new Telerik.WinControls.UI.RadButton();
            this.txtFileName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.listFormatList = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFormatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFormatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(47, 3);
            this.txtUrl.MaxLength = 300;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(480, 24);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrl.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(2, 2);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 25);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "URL";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(451, 296);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(110, 24);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.ThemeName = "VisualStudio2012Dark";
            this.btnDownload.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(2, 33);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(119, 25);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Download Path";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavePath.Location = new System.Drawing.Point(127, 34);
            this.txtSavePath.MaxLength = 300;
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(400, 24);
            this.txtSavePath.TabIndex = 1;
            this.txtSavePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSavePath.ThemeName = "VisualStudio2012Dark";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.Location = new System.Drawing.Point(533, 34);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(28, 24);
            this.btnSelectPath.TabIndex = 4;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectPath.ThemeName = "VisualStudio2012Dark";
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnGetFormatList
            // 
            this.btnGetFormatList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFormatList.Location = new System.Drawing.Point(533, 4);
            this.btnGetFormatList.Name = "btnGetFormatList";
            this.btnGetFormatList.Size = new System.Drawing.Size(28, 24);
            this.btnGetFormatList.TabIndex = 8;
            this.btnGetFormatList.Text = "->";
            this.btnGetFormatList.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetFormatList.ThemeName = "VisualStudio2012Dark";
            this.btnGetFormatList.Click += new System.EventHandler(this.btnGetFormatList_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(127, 64);
            this.txtFileName.MaxLength = 300;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(434, 24);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.Text = "Leave blank for default";
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFileName.ThemeName = "VisualStudio2012Dark";
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            this.txtFileName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFileName_MouseClick);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.White;
            this.radLabel4.Location = new System.Drawing.Point(2, 63);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(87, 25);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Video title ";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // listFormatList
            // 
            this.listFormatList.ItemHeight = 24;
            this.listFormatList.Location = new System.Drawing.Point(2, 93);
            this.listFormatList.Name = "listFormatList";
            this.listFormatList.Size = new System.Drawing.Size(559, 198);
            this.listFormatList.TabIndex = 9;
            this.listFormatList.ThemeName = "FluentDark";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 321);
            this.Controls.Add(this.listFormatList);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnGetFormatList);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "OboSoft Youtube Downloader";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSavePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFormatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFormatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadTextBox txtUrl;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnDownload;
        private Telerik.WinControls.UI.RadTextBox txtSavePath;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnSelectPath;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadButton btnGetFormatList;
        private Telerik.WinControls.UI.RadTextBox txtFileName;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadListControl listFormatList;
    }
}