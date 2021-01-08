using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FTPClient
{
    public partial class Browser : Form
    {
        private FTPclient _client;
        private string currentDir = "/";
        private FTPfileInfo currentFile;
        private FTPdirectory currentDirectory;

        //The directory to use for the previous/next buttons
        private FTPdirectory currentDirectoryForNav;

        public Browser(FTPclient client)
        {
            InitializeComponent();
            _client = client;
            FormClosing += Browser_FormClosing;
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //delete any temp files we created
            var dir = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(f => f.Contains("\\temp")).ToList();
            dir.ForEach(x => File.Delete(x));
        }

        //Just UI stuff
        public void LoadDirectory(FTPdirectory dir)
        {
            currentDirectoryTextbox.Text = currentDir;
            currentDirectory = dir;
            //Show the end of the text (the deepest dir)
            currentDirectoryTextbox.SelectionStart = currentDirectoryTextbox.Text.Length;
            currentDirectoryTextbox.SelectionLength = 0;

            DirectoryList.Controls.Clear();
            var parentDirItem = new DirectoryItem();
            parentDirItem.Click = async (sender, args) => { await ParentDirectoryClick(sender, args); }; ;
            DirectoryList.Controls.Add(parentDirItem);

            foreach (var file in dir)
            {
                var fileItem = new DirectoryItem(file);
                if(file.FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
                {
                    fileItem.Click = async (sender, args) => { await DirectoryClick(sender, args); }; ;
                }
                else
                {
                    fileItem.Click = async (sender, args) => { await FileClick(sender, args, file); };
                }

                DirectoryList.Controls.Add(fileItem);
            }
        }

        public async Task ParentDirectoryClick(object sender, EventArgs e)
        {
            try
            {
                string newDirPath = FTPdirectory.GetParentDirectory(currentDir);
                var newDir = await _client.ListDirectoryDetail(newDirPath);
                currentDir = newDirPath;
                LoadDirectory(newDir);
            }
            catch
            {

            }
        }

        public async Task FileClick(object sender, EventArgs e, FTPfileInfo file)
        {
            loadingSpinner.Visible = true;
            currentDirectoryForNav = currentDirectory;
            string ext = file.Extension.ToLower();
            currentFile = file;
            if(ext == "jpg" || ext == "png" || ext == "jpeg" || ext == "bmp")
            {
                videoPreviewPlayer.Visible = false;
                textPreviewBox.Visible = false;
                previewPictureBox.Visible = true;
                using (var ftpResponse = await _client.GetRawResponseStream(file))
                {
                    using(var fileContentStream = ftpResponse.GetResponseStream())
                    {
                        previewPictureBox.Visible = true;
                        previewPictureBox.Image = Image.FromStream(fileContentStream);
                    }
                }
                    
            }

            else if(ext == "avi" || ext == "mp4" || ext == "wma" || ext == "mp3")
            {
                await _client.Download(file, Directory.GetCurrentDirectory() + "\\" + "temp." + ext, true);
                videoPreviewPlayer.Visible = true;
                textPreviewBox.Visible = false;
                previewPictureBox.Visible = false;
                videoPreviewPlayer.Warning += (Sender, Events) => { };
                videoPreviewPlayer.settings.enableErrorDialogs = false;
                videoPreviewPlayer.URL = Directory.GetCurrentDirectory() + "\\" + "temp." + ext;
                videoPreviewPlayer.settings.autoStart = true;
            }

            else
            {
                videoPreviewPlayer.Visible = false;
                textPreviewBox.Visible = true;
                previewPictureBox.Visible = false;

                var response = await _client.GetRawResponse(file);
                textPreviewBox.Text = Encoding.Default.GetString(response);
            }

            loadingSpinner.Visible = false;
        }

        public async Task DirectoryClick(object sender, EventArgs e)
        {
            loadingSpinner.Visible = true;
            string newDirPath = ((LinkLabel)sender).Text;
            var newDir = await _client.ListDirectoryDetail(currentDir+newDirPath);
            currentDir = currentDir + newDirPath + "/";
            LoadDirectory(newDir);
            loadingSpinner.Visible = false;
        }

        private async void Browser_Load(object sender, EventArgs e)
        {
            loadingSpinner.Visible = true;
            var directory = await _client.ListDirectoryDetail("");
            LoadDirectory(directory);
            loadingSpinner.Visible = false;
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileOk += async (Sender, CancelEventArgs) => 
            { 
                if(!string.IsNullOrWhiteSpace(fileDialog.FileName))
                {
                    await _client.Download(currentFile, fileDialog.FileName, true);
                }
            };
            fileDialog.ShowDialog();
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            var currentImage = previewPictureBox.Image;
            currentImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            previewPictureBox.Image = currentImage;
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            var currentImage = previewPictureBox.Image;
            currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            previewPictureBox.Image = currentImage;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(currentDirectoryForNav != null)
            {
                int idx = currentDirectoryForNav.FindIndex(f => f.Equals(currentFile));
                idx = idx < currentDirectoryForNav.Count ? idx : -1;
                FileClick(null, null, currentDirectoryForNav.ElementAt(idx + 1));
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentDirectoryForNav != null)
            {
                int idx = currentDirectoryForNav.FindIndex(f => f.Equals(currentFile));
                idx = idx == 0 ? currentDirectoryForNav.Count : idx;
                FileClick(null, null, currentDirectoryForNav.ElementAt(idx - 1));
            }
        }
    }
}
