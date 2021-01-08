namespace FTPClient
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.DirectoryList = new System.Windows.Forms.FlowLayoutPanel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.currentDirectoryTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.navigateToDirButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateLeftButton = new System.Windows.Forms.ToolStripButton();
            this.rotateRightButton = new System.Windows.Forms.ToolStripButton();
            this.downloadButton = new System.Windows.Forms.ToolStripButton();
            this.fullscreenButton = new System.Windows.Forms.ToolStripButton();
            this.previousButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.loadingSpinner = new System.Windows.Forms.PictureBox();
            this.videoPreviewPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textPreviewBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPreviewPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // DirectoryList
            // 
            this.DirectoryList.AutoScroll = true;
            this.DirectoryList.AutoSize = true;
            this.DirectoryList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirectoryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.DirectoryList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DirectoryList.Location = new System.Drawing.Point(0, 0);
            this.DirectoryList.Name = "DirectoryList";
            this.DirectoryList.Size = new System.Drawing.Size(0, 450);
            this.DirectoryList.TabIndex = 1;
            this.DirectoryList.WrapContents = false;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(800, 450);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 2;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.currentDirectoryTextbox,
            this.navigateToDirButton,
            this.toolStripSeparator1,
            this.rotateLeftButton,
            this.rotateRightButton,
            this.downloadButton,
            this.fullscreenButton,
            this.previousButton,
            this.nextButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 28);
            this.toolStripLabel1.Text = "Current Directory: ";
            // 
            // currentDirectoryTextbox
            // 
            this.currentDirectoryTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.currentDirectoryTextbox.Name = "currentDirectoryTextbox";
            this.currentDirectoryTextbox.Size = new System.Drawing.Size(250, 31);
            // 
            // navigateToDirButton
            // 
            this.navigateToDirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navigateToDirButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.navigateToDirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigateToDirButton.Name = "navigateToDirButton";
            this.navigateToDirButton.Size = new System.Drawing.Size(32, 28);
            this.navigateToDirButton.Text = "Go";
            this.navigateToDirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftButton.Image")));
            this.rotateLeftButton.ImageTransparentColor = System.Drawing.Color.GhostWhite;
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(29, 28);
            this.rotateLeftButton.Text = "Rotate Left";
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateRightButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateRightButton.Image")));
            this.rotateRightButton.ImageTransparentColor = System.Drawing.Color.GhostWhite;
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(29, 28);
            this.rotateRightButton.Text = "toolStripButton2";
            this.rotateRightButton.ToolTipText = "Rotate Right";
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downloadButton.Image = ((System.Drawing.Image)(resources.GetObject("downloadButton.Image")));
            this.downloadButton.ImageTransparentColor = System.Drawing.Color.GhostWhite;
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(29, 28);
            this.downloadButton.ToolTipText = "Download";
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fullscreenButton.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenButton.Image")));
            this.fullscreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(78, 28);
            this.fullscreenButton.Text = "Fullscreen";
            // 
            // previousButton
            // 
            this.previousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(68, 28);
            this.previousButton.Text = "Previous";
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(44, 28);
            this.nextButton.Text = "Next";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Image = ((System.Drawing.Image)(resources.GetObject("loadingSpinner.Image")));
            this.loadingSpinner.Location = new System.Drawing.Point(370, 137);
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(222, 200);
            this.loadingSpinner.TabIndex = 4;
            this.loadingSpinner.TabStop = false;
            // 
            // videoPreviewPlayer
            // 
            this.videoPreviewPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPreviewPlayer.Enabled = true;
            this.videoPreviewPlayer.Location = new System.Drawing.Point(0, 31);
            this.videoPreviewPlayer.Name = "videoPreviewPlayer";
            this.videoPreviewPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPreviewPlayer.OcxState")));
            this.videoPreviewPlayer.Size = new System.Drawing.Size(800, 419);
            this.videoPreviewPlayer.TabIndex = 5;
            this.videoPreviewPlayer.Visible = false;
            // 
            // textPreviewBox
            // 
            this.textPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPreviewBox.Location = new System.Drawing.Point(0, 31);
            this.textPreviewBox.Multiline = true;
            this.textPreviewBox.Name = "textPreviewBox";
            this.textPreviewBox.ReadOnly = true;
            this.textPreviewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textPreviewBox.Size = new System.Drawing.Size(800, 419);
            this.textPreviewBox.TabIndex = 6;
            this.textPreviewBox.Visible = false;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPreviewBox);
            this.Controls.Add(this.videoPreviewPlayer);
            this.Controls.Add(this.loadingSpinner);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.DirectoryList);
            this.Name = "Browser";
            this.Text = "Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Browser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPreviewPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DirectoryList;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton rotateLeftButton;
        private System.Windows.Forms.ToolStripButton rotateRightButton;
        private System.Windows.Forms.ToolStripButton downloadButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox currentDirectoryTextbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton navigateToDirButton;
        private System.Windows.Forms.ToolStripButton fullscreenButton;
        private System.Windows.Forms.PictureBox loadingSpinner;
        private System.Windows.Forms.ToolStripButton previousButton;
        private System.Windows.Forms.ToolStripButton nextButton;
        private AxWMPLib.AxWindowsMediaPlayer videoPreviewPlayer;
        private System.Windows.Forms.TextBox textPreviewBox;
    }
}