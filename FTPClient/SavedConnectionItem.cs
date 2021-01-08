using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class SavedConnectionItem : UserControl
    {
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }
        public SavedConnectionItem()
        {
            InitializeComponent();
        }
        public SavedConnectionItem(SavedConnection connection)
        {
            InitializeComponent();
            FriendlyNameLabel.Text = connection.FriendlyName;
            AddressLabel.Text = connection.Address;
            usernameLabel.Text = connection.Username;
        }
    }

    public class SavedConnection
    {
        public string FriendlyName { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Tag { get; set; }
    }
}
