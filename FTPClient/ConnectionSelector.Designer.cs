namespace FTPClient
{
    partial class ConnectionSelector
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
            System.Windows.Forms.Label SavedConnectionsLabel;
            System.Windows.Forms.Label ConnectionLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.serverAddressTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.savedConnectionsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            SavedConnectionsLabel = new System.Windows.Forms.Label();
            ConnectionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SavedConnectionsLabel
            // 
            SavedConnectionsLabel.AutoSize = true;
            SavedConnectionsLabel.Location = new System.Drawing.Point(379, 9);
            SavedConnectionsLabel.Name = "SavedConnectionsLabel";
            SavedConnectionsLabel.Size = new System.Drawing.Size(134, 17);
            SavedConnectionsLabel.TabIndex = 0;
            SavedConnectionsLabel.Text = "Saved Connections:";
            // 
            // ConnectionLabel
            // 
            ConnectionLabel.AutoSize = true;
            ConnectionLabel.Location = new System.Drawing.Point(12, 9);
            ConnectionLabel.Name = "ConnectionLabel";
            ConnectionLabel.Size = new System.Drawing.Size(64, 17);
            ConnectionLabel.TabIndex = 1;
            ConnectionLabel.Text = "Connect:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 17);
            label1.TabIndex = 4;
            label1.Text = "Server Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 17);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 17);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 173);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 17);
            label4.TabIndex = 7;
            label4.Text = "Name (optional):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 287);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(251, 34);
            label5.TabIndex = 8;
            label5.Text = "Leave Username and Password blank \nif there is no password.";
            // 
            // serverAddressTextbox
            // 
            this.serverAddressTextbox.Location = new System.Drawing.Point(153, 46);
            this.serverAddressTextbox.Name = "serverAddressTextbox";
            this.serverAddressTextbox.Size = new System.Drawing.Size(208, 22);
            this.serverAddressTextbox.TabIndex = 9;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(153, 88);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(208, 22);
            this.usernameTextbox.TabIndex = 10;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(153, 130);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(208, 22);
            this.passwordTextbox.TabIndex = 11;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(153, 173);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(208, 22);
            this.nameTextbox.TabIndex = 12;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(100, 212);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += (sender, EventArgs) => { connectButton_Click(sender, EventArgs); };
            // 
            // savedConnectionsFlowLayout
            // 
            this.savedConnectionsFlowLayout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.savedConnectionsFlowLayout.AutoScroll = true;
            this.savedConnectionsFlowLayout.AutoSize = true;
            this.savedConnectionsFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savedConnectionsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.savedConnectionsFlowLayout.Location = new System.Drawing.Point(788, 46);
            this.savedConnectionsFlowLayout.Name = "savedConnectionsFlowLayout";
            this.savedConnectionsFlowLayout.Size = new System.Drawing.Size(0, 0);
            this.savedConnectionsFlowLayout.TabIndex = 14;
            // 
            // ConnectionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savedConnectionsFlowLayout);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.serverAddressTextbox);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(ConnectionLabel);
            this.Controls.Add(SavedConnectionsLabel);
            this.Name = "ConnectionSelector";
            this.Text = "FTP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverAddressTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.FlowLayoutPanel savedConnectionsFlowLayout;
    }
}

