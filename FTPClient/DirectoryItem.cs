using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class DirectoryItem : GroupBox
    {
        public new EventHandler Click { set { FilenameLinkLabel.Click += value; } }
        public FTPfileInfo FileInfo { get; internal set; }

        public DirectoryItem()
        {
            //for adding parent directory and loading in the designer.
            InitializeComponent();
            IconPictureBox.Image = Properties.Resources.dir;
            FilenameLinkLabel.Text = "[Parent Directory]";
        }
        public DirectoryItem(FTPfileInfo fileInfo)
        {
            InitializeComponent();
            FileInfo = fileInfo;
            if (fileInfo.FileType == FTPfileInfo.DirectoryEntryTypes.Directory)
            {
                IconPictureBox.Image = Properties.Resources.dir;
            }
            else
            {
                IconPictureBox.Image = Properties.Resources.file;
            }

            FilenameLinkLabel.Text = fileInfo.Filename;
        }
    }
}
