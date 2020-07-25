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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.btnSelectPath = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(47, 3);
            this.txtUrl.MaxLength = 300;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(445, 24);
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
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(382, 248);
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
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(119, 34);
            this.radTextBox1.MaxLength = 300;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(339, 24);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radTextBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.Location = new System.Drawing.Point(464, 34);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(28, 24);
            this.btnSelectPath.TabIndex = 4;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectPath.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(2, 64);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(113, 25);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Output format";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // txtFormat
            // 
            this.txtFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txtFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFormat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFormat.FormattingEnabled = true;
            this.txtFormat.Items.AddRange(new object[] {
            "source",
            "mp4",
            "flv",
            "mp3",
            "m4a"});
            this.txtFormat.Location = new System.Drawing.Point(119, 65);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(130, 25);
            this.txtFormat.TabIndex = 6;
            this.txtFormat.Text = "source";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 275);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.radTextBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadTextBox txtUrl;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnDownload;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnSelectPath;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.ComboBox txtFormat;
    }
}