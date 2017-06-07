﻿namespace SpotifyAPI.Example
{
    partial class WebControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.authButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savedTracksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.savedTracksCountLabel = new System.Windows.Forms.Label();
            this.playlistsListBox = new System.Windows.Forms.ListBox();
            this.playlistsCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(4, 4);
            this.authButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(1285, 59);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "Authenticate SpotifyWeb API";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display-Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account-Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saved-Tracks:";
            // 
            // savedTracksListView
            // 
            this.savedTracksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.savedTracksListView.FullRowSelect = true;
            this.savedTracksListView.Location = new System.Drawing.Point(324, 114);
            this.savedTracksListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savedTracksListView.Name = "savedTracksListView";
            this.savedTracksListView.Size = new System.Drawing.Size(512, 692);
            this.savedTracksListView.TabIndex = 10;
            this.savedTracksListView.UseCompatibleStateImageBehavior = false;
            this.savedTracksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artist";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Album";
            this.columnHeader3.Width = 131;
            // 
            // savedTracksCountLabel
            // 
            this.savedTracksCountLabel.AutoSize = true;
            this.savedTracksCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedTracksCountLabel.Location = new System.Drawing.Point(461, 90);
            this.savedTracksCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savedTracksCountLabel.Name = "savedTracksCountLabel";
            this.savedTracksCountLabel.Size = new System.Drawing.Size(15, 20);
            this.savedTracksCountLabel.TabIndex = 11;
            this.savedTracksCountLabel.Text = "-";
            // 
            // playlistsListBox
            // 
            this.playlistsListBox.FormattingEnabled = true;
            this.playlistsListBox.ItemHeight = 16;
            this.playlistsListBox.Location = new System.Drawing.Point(845, 114);
            this.playlistsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playlistsListBox.Name = "playlistsListBox";
            this.playlistsListBox.Size = new System.Drawing.Size(405, 692);
            this.playlistsListBox.TabIndex = 12;
            // 
            // playlistsCountLabel
            // 
            this.playlistsCountLabel.AutoSize = true;
            this.playlistsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistsCountLabel.Location = new System.Drawing.Point(933, 90);
            this.playlistsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playlistsCountLabel.Name = "playlistsCountLabel";
            this.playlistsCountLabel.Size = new System.Drawing.Size(15, 20);
            this.playlistsCountLabel.TabIndex = 14;
            this.playlistsCountLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Playlists:";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNameLabel.Location = new System.Drawing.Point(145, 90);
            this.displayNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(15, 20);
            this.displayNameLabel.TabIndex = 15;
            this.displayNameLabel.Text = "-";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(93, 111);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(15, 20);
            this.countryLabel.TabIndex = 16;
            this.countryLabel.Text = "-";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(80, 132);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(15, 20);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "-";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(145, 153);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(15, 20);
            this.accountLabel.TabIndex = 18;
            this.accountLabel.Text = "-";
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(4, 177);
            this.avatarPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(312, 261);
            this.avatarPictureBox.TabIndex = 19;
            this.avatarPictureBox.TabStop = false;
            // 
            // WebControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.displayNameLabel);
            this.Controls.Add(this.playlistsCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playlistsListBox);
            this.Controls.Add(this.savedTracksCountLabel);
            this.Controls.Add(this.savedTracksListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WebControl";
            this.Size = new System.Drawing.Size(1293, 825);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView savedTracksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label savedTracksCountLabel;
        private System.Windows.Forms.ListBox playlistsListBox;
        private System.Windows.Forms.Label playlistsCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.PictureBox avatarPictureBox;
    }
}
