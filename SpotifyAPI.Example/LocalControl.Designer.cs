namespace SpotifyAPI.Example
{
    partial class LocalControl
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
            this.components = new System.ComponentModel.Container();
            this.titleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.artistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.albumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.smallAlbumPicture = new System.Windows.Forms.PictureBox();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.timeLeft = new System.Windows.Forms.Label();
            this.advertLabel = new System.Windows.Forms.Label();
            this.isPlayingLabel = new System.Windows.Forms.Label();
            this.timeTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.skipBtn = new System.Windows.Forms.PictureBox();
            this.btnPlayPause = new System.Windows.Forms.PictureBox();
            this.titleMarquee = new System.Windows.Forms.Timer(this.components);
            this.albumMarquee = new System.Windows.Forms.Timer(this.components);
            this.artistMarquee = new System.Windows.Forms.Timer(this.components);
            this.albumRight = new System.Windows.Forms.LinkLabel();
            this.artistRight = new System.Windows.Forms.LinkLabel();
            this.trackRight = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.smallAlbumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLinkLabel
            // 
            this.titleLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.titleLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLinkLabel.AutoSize = true;
            this.titleLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.titleLinkLabel.ForeColor = System.Drawing.Color.White;
            this.titleLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.titleLinkLabel.LinkColor = System.Drawing.Color.White;
            this.titleLinkLabel.Location = new System.Drawing.Point(86, 6);
            this.titleLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLinkLabel.Name = "titleLinkLabel";
            this.titleLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.titleLinkLabel.TabIndex = 5;
            this.titleLinkLabel.TabStop = true;
            this.titleLinkLabel.Text = "-";
            this.titleLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLinkLabel.MouseEnter += new System.EventHandler(this.titleLinkLabel_MouseEnter);
            // 
            // artistLinkLabel
            // 
            this.artistLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.artistLinkLabel.AutoSize = true;
            this.artistLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 6.5F);
            this.artistLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.artistLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.artistLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.artistLinkLabel.Location = new System.Drawing.Point(86, 25);
            this.artistLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistLinkLabel.Name = "artistLinkLabel";
            this.artistLinkLabel.Size = new System.Drawing.Size(11, 13);
            this.artistLinkLabel.TabIndex = 6;
            this.artistLinkLabel.TabStop = true;
            this.artistLinkLabel.Text = "-";
            this.artistLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.artistLinkLabel.MouseEnter += new System.EventHandler(this.artistLinkLabel_MouseEnter);
            // 
            // albumLinkLabel
            // 
            this.albumLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.albumLinkLabel.AutoSize = true;
            this.albumLinkLabel.Font = new System.Drawing.Font("Nirmala UI", 6.5F);
            this.albumLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.albumLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.albumLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.albumLinkLabel.Location = new System.Drawing.Point(86, 42);
            this.albumLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumLinkLabel.Name = "albumLinkLabel";
            this.albumLinkLabel.Size = new System.Drawing.Size(11, 13);
            this.albumLinkLabel.TabIndex = 7;
            this.albumLinkLabel.TabStop = true;
            this.albumLinkLabel.Text = "-";
            this.albumLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.albumLinkLabel.MouseEnter += new System.EventHandler(this.albumLinkLabel_MouseEnter);
            // 
            // smallAlbumPicture
            // 
            this.smallAlbumPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smallAlbumPicture.Location = new System.Drawing.Point(4, 4);
            this.smallAlbumPicture.Margin = new System.Windows.Forms.Padding(4);
            this.smallAlbumPicture.Name = "smallAlbumPicture";
            this.smallAlbumPicture.Size = new System.Drawing.Size(80, 80);
            this.smallAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smallAlbumPicture.TabIndex = 5;
            this.smallAlbumPicture.TabStop = false;
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.timeProgressBar.Location = new System.Drawing.Point(30, 106);
            this.timeProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.timeProgressBar.MarqueeAnimationSpeed = 0;
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(200, 7);
            this.timeProgressBar.Step = 5;
            this.timeProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timeProgressBar.TabIndex = 43;
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.timeLeft.ForeColor = System.Drawing.Color.White;
            this.timeLeft.Location = new System.Drawing.Point(4, 102);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(10, 13);
            this.timeLeft.TabIndex = 29;
            this.timeLeft.Text = "-";
            // 
            // advertLabel
            // 
            this.advertLabel.AutoSize = true;
            this.advertLabel.Location = new System.Drawing.Point(91, 76);
            this.advertLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.advertLabel.Name = "advertLabel";
            this.advertLabel.Size = new System.Drawing.Size(0, 17);
            this.advertLabel.TabIndex = 31;
            // 
            // isPlayingLabel
            // 
            this.isPlayingLabel.AutoSize = true;
            this.isPlayingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPlayingLabel.Location = new System.Drawing.Point(54, 83);
            this.isPlayingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isPlayingLabel.Name = "isPlayingLabel";
            this.isPlayingLabel.Size = new System.Drawing.Size(15, 20);
            this.isPlayingLabel.TabIndex = 14;
            this.isPlayingLabel.Text = "-";
            this.isPlayingLabel.Visible = false;
            // 
            // timeTotal
            // 
            this.timeTotal.AutoSize = true;
            this.timeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.timeTotal.ForeColor = System.Drawing.Color.White;
            this.timeTotal.Location = new System.Drawing.Point(232, 102);
            this.timeTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeTotal.Name = "timeTotal";
            this.timeTotal.Size = new System.Drawing.Size(10, 13);
            this.timeTotal.TabIndex = 32;
            this.timeTotal.Text = "-";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::SpotifyAPI.Example.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(240, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 19);
            this.btnExit.TabIndex = 33;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = global::SpotifyAPI.Example.Properties.Resources.prev1;
            this.prevBtn.Location = new System.Drawing.Point(101, 74);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(15, 15);
            this.prevBtn.TabIndex = 52;
            this.prevBtn.TabStop = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            this.prevBtn.MouseEnter += new System.EventHandler(this.prevBtn_MouseEnter);
            this.prevBtn.MouseLeave += new System.EventHandler(this.prevBtn_MouseLeave);
            // 
            // skipBtn
            // 
            this.skipBtn.Image = global::SpotifyAPI.Example.Properties.Resources.next1;
            this.skipBtn.Location = new System.Drawing.Point(189, 74);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(15, 15);
            this.skipBtn.TabIndex = 53;
            this.skipBtn.TabStop = false;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            this.skipBtn.MouseEnter += new System.EventHandler(this.skipBtn_MouseEnter);
            this.skipBtn.MouseLeave += new System.EventHandler(this.skipBtn_MouseLeave);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Image = global::SpotifyAPI.Example.Properties.Resources.play1;
            this.btnPlayPause.Location = new System.Drawing.Point(133, 61);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(38, 37);
            this.btnPlayPause.TabIndex = 54;
            this.btnPlayPause.TabStop = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            this.btnPlayPause.MouseEnter += new System.EventHandler(this.btnPlayPause_MouseEnter);
            this.btnPlayPause.MouseLeave += new System.EventHandler(this.btnPlayPause_MouseLeave);
            // 
            // titleMarquee
            // 
            this.titleMarquee.Interval = 25;
            this.titleMarquee.Tick += new System.EventHandler(this.titleMarquee_Tick);
            // 
            // albumMarquee
            // 
            this.albumMarquee.Interval = 25;
            this.albumMarquee.Tick += new System.EventHandler(this.albumMarquee_Tick);
            // 
            // artistMarquee
            // 
            this.artistMarquee.Interval = 25;
            this.artistMarquee.Tick += new System.EventHandler(this.artistMarquee_Tick);
            // 
            // albumRight
            // 
            this.albumRight.ActiveLinkColor = System.Drawing.Color.White;
            this.albumRight.AutoSize = true;
            this.albumRight.Font = new System.Drawing.Font("Nirmala UI", 6.5F);
            this.albumRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.albumRight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.albumRight.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.albumRight.Location = new System.Drawing.Point(260, 42);
            this.albumRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumRight.Name = "albumRight";
            this.albumRight.Size = new System.Drawing.Size(11, 13);
            this.albumRight.TabIndex = 57;
            this.albumRight.TabStop = true;
            this.albumRight.Text = "-";
            this.albumRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistRight
            // 
            this.artistRight.ActiveLinkColor = System.Drawing.Color.White;
            this.artistRight.AutoSize = true;
            this.artistRight.Font = new System.Drawing.Font("Nirmala UI", 6.5F);
            this.artistRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.artistRight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.artistRight.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.artistRight.Location = new System.Drawing.Point(260, 25);
            this.artistRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistRight.Name = "artistRight";
            this.artistRight.Size = new System.Drawing.Size(11, 13);
            this.artistRight.TabIndex = 56;
            this.artistRight.TabStop = true;
            this.artistRight.Text = "-";
            this.artistRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackRight
            // 
            this.trackRight.ActiveLinkColor = System.Drawing.Color.White;
            this.trackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackRight.AutoSize = true;
            this.trackRight.Font = new System.Drawing.Font("Nirmala UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.trackRight.ForeColor = System.Drawing.Color.White;
            this.trackRight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.trackRight.LinkColor = System.Drawing.Color.White;
            this.trackRight.Location = new System.Drawing.Point(260, 6);
            this.trackRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackRight.Name = "trackRight";
            this.trackRight.Size = new System.Drawing.Size(13, 17);
            this.trackRight.TabIndex = 55;
            this.trackRight.TabStop = true;
            this.trackRight.Text = "-";
            this.trackRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-18, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 85);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 77);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::SpotifyAPI.Example.Properties.Resources.plus;
            this.saveBtn.Location = new System.Drawing.Point(227, 74);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(15, 15);
            this.saveBtn.TabIndex = 60;
            this.saveBtn.TabStop = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // LocalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smallAlbumPicture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.albumRight);
            this.Controls.Add(this.artistRight);
            this.Controls.Add(this.trackRight);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.timeTotal);
            this.Controls.Add(this.isPlayingLabel);
            this.Controls.Add(this.advertLabel);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.timeProgressBar);
            this.Controls.Add(this.albumLinkLabel);
            this.Controls.Add(this.artistLinkLabel);
            this.Controls.Add(this.titleLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocalControl";
            this.Size = new System.Drawing.Size(261, 122);
            this.Load += new System.EventHandler(this.LocalControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LocalControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LocalControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LocalControl_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.smallAlbumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel titleLinkLabel;
        private System.Windows.Forms.LinkLabel artistLinkLabel;
        private System.Windows.Forms.LinkLabel albumLinkLabel;
        private System.Windows.Forms.PictureBox smallAlbumPicture;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label advertLabel;
        private System.Windows.Forms.Label isPlayingLabel;
        private System.Windows.Forms.Label timeTotal;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox prevBtn;
        private System.Windows.Forms.PictureBox skipBtn;
        private System.Windows.Forms.PictureBox btnPlayPause;
        private System.Windows.Forms.Timer titleMarquee;
        private System.Windows.Forms.Timer albumMarquee;
        private System.Windows.Forms.Timer artistMarquee;
        private System.Windows.Forms.LinkLabel albumRight;
        private System.Windows.Forms.LinkLabel artistRight;
        private System.Windows.Forms.LinkLabel trackRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox saveBtn;
    }
}
