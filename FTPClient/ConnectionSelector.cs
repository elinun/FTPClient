using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class ConnectionSelector : Form
    {
        public ConnectionSelector()
        {
            InitializeComponent();

            //Load saved connections
            foreach(var connection in Properties.Settings.Default.SavedConnections)
            {
                var connectionItem = new SavedConnectionItem(connection);
                connectionItem.Click += (sender, EventArgs) => { connectButton_Click(sender, EventArgs, connection); };
                savedConnectionsFlowLayout.Controls.Add(connectionItem);
            }
        }

        private void connectButton_Click(object sender, EventArgs e, SavedConnection connection = null)
        {
            SavedConnection toConnect;
            if (connection == null)
            {
                //update saved connections list
                //TODO: Check if connection already exists
                var connectionItem = new SavedConnection
                {
                    Address = serverAddressTextbox.Text,
                    FriendlyName = nameTextbox.Text,
                    Username = usernameTextbox.Text,
                    Password = passwordTextbox.Text,
                    Tag = Guid.NewGuid().ToString()
                };
                var savedConnections = Properties.Settings.Default.SavedConnections;
                savedConnections.Add(connectionItem);
                Properties.Settings.Default.SavedConnections = savedConnections;
                Properties.Settings.Default.Save();
                toConnect = connectionItem;                
            }
            else
            {
                toConnect = connection;
            }
            //TODO add connection loading graphic.

            //connect
            this.Hide();
            var browserForm = new Browser(new FTPclient(toConnect.Address, toConnect.Username, toConnect.Password));
            browserForm.ShowDialog();
            this.Close();
        }
    }
}
