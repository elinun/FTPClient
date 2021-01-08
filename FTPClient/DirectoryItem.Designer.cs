using System.Windows.Forms;

namespace FTPClient
{
    partial class DirectoryItem
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.FilenameLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(32, 64);
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // FilenameLinkLabel
            // 
            this.FilenameLinkLabel.AutoSize = true;
            this.FilenameLinkLabel.Location = new System.Drawing.Point(32, 0);
            this.FilenameLinkLabel.Name = "FilenameLinkLabel";
            this.FilenameLinkLabel.Size = new System.Drawing.Size(100, 17);
            this.FilenameLinkLabel.TabIndex = 0;
            this.FilenameLinkLabel.TabStop = true;
            this.FilenameLinkLabel.Text = "linkLabel1";
            // 
            // DirectoryItem
            // 
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.FilenameLinkLabel);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.LinkLabel FilenameLinkLabel;
    }
}
