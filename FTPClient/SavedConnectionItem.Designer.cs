namespace FTPClient
{
    partial class SavedConnectionItem
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
            this.FriendlyNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FriendlyNameLabel
            // 
            this.FriendlyNameLabel.AutoSize = true;
            this.FriendlyNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FriendlyNameLabel.Name = "FriendlyNameLabel";
            this.FriendlyNameLabel.Size = new System.Drawing.Size(45, 17);
            this.FriendlyNameLabel.TabIndex = 0;
            this.FriendlyNameLabel.Text = "Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddressLabel.Location = new System.Drawing.Point(3, 30);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernameLabel.Location = new System.Drawing.Point(3, 65);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // SavedConnectionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.FriendlyNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "SavedConnectionItem";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FriendlyNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}
