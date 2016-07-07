using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace SpotifyAPI.Example
{
    public partial class LocalControl : UserControl
    {
        private readonly SpotifyLocalAPI _spotify;
        private Track _currentTrack;
        public Point trackLLoc = new System.Drawing.Point(3, 4);
        public Point trackRLoc = new System.Drawing.Point(157, 4);
        public Point artistLLoc = new System.Drawing.Point(3, 22);
        public Point artistRLoc = new System.Drawing.Point(157, 22);
        public Point albumLLoc = new System.Drawing.Point(3, 36);
        public Point albumRLoc = new System.Drawing.Point(157, 36);


        public LocalControl()
        {
            InitializeComponent();

            _spotify = new SpotifyLocalAPI();
            _spotify.OnPlayStateChange += _spotify_OnPlayStateChange;
            _spotify.OnTrackChange += _spotify_OnTrackChange;
            _spotify.OnTrackTimeChange += _spotify_OnTrackTimeChange;
            _spotify.OnVolumeChange += _spotify_OnVolumeChange;
            _spotify.SynchronizingObject = this;

            artistLinkLabel.Click += (sender, args) => Process.Start(artistLinkLabel.Tag.ToString());
            albumLinkLabel.Click += (sender, args) => Process.Start(albumLinkLabel.Tag.ToString());
            titleLinkLabel.Click += (sender, args) => Process.Start(titleLinkLabel.Tag.ToString());

            Connect();

        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST)
        //        m.Result = (IntPtr)(HT_CAPTION);
        //}

        //private const int WM_NCHITTEST = 0x84;
        //private const int HT_CLIENT = 0x1;
        //private const int HT_CAPTION = 0x2;

        public void Connect()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                MessageBox.Show(@"Spotify isn't running!");
                return;
            }
            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
            {
                MessageBox.Show(@"SpotifyWebHelper isn't running!");
                return;
            }

            bool successful = _spotify.Connect();
            if (successful)
            {
                UpdateInfos();
                _spotify.ListenForEvents = true;
            }
            else
            {
                DialogResult res = MessageBox.Show(@"Couldn't connect to the spotify client. Retry?", @"Spotify", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    Connect();
            }
        }



        public void UpdateInfos()
        {
            StatusResponse status = _spotify.GetStatus();
            if (status == null)
                return;

            //Basic Spotify Infos
            UpdatePlayingStatus(status.Playing);
            repeatShuffleLabel.Text = status.Repeat + @" and " + status.Shuffle;

            if (status.Track != null) //Update track infos
                UpdateTrack(status.Track);

            if (isPlayingLabel.Text == "True")
            {
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pause1;
            }
            else
            {
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.play1;
            }
        }

        public async void UpdateTrack(Track track)
        {
            _currentTrack = track;
            timeProgressBar.Maximum = track.Length;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            titleLinkLabel.UseMnemonic = false;
            titleLinkLabel.Text = track.TrackResource.Name;
            titleLinkLabel.Tag = track.TrackResource.Uri;
            trackRight.UseMnemonic = false;
            trackRight.Text = track.TrackResource.Name;
            trackRight.Tag = track.TrackResource.Uri;

            artistLinkLabel.UseMnemonic = false;
            artistLinkLabel.Text = track.ArtistResource.Name;
            artistLinkLabel.Tag = track.ArtistResource.Uri;
            artistRight.UseMnemonic = false;
            artistRight.Text = track.ArtistResource.Name;
            artistRight.Tag = track.ArtistResource.Uri;

            albumLinkLabel.UseMnemonic = false;
            albumLinkLabel.Text = track.AlbumResource.Name;
            albumLinkLabel.Tag = track.AlbumResource.Uri;
            albumRight.UseMnemonic = false;
            albumRight.Text = track.AlbumResource.Name;
            albumRight.Tag = track.AlbumResource.Uri;

            SpotifyUri uri = track.TrackResource.ParseUri();

            smallAlbumPicture.BackgroundImage = await track.GetAlbumArtAsync(AlbumArtSize.Size160);
            //smallAlbumPicture.BackgroundImage = track.GetAlbumArt(AlbumArtSize.Size160);
        }

        public void UpdatePlayingStatus(bool playing)
        {
            isPlayingLabel.Text = playing.ToString();
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pause1;
            else btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.play1;
        }

        private void _spotify_OnVolumeChange(object sender, VolumeChangeEventArgs e)
        {
            volumeLabel.Text = (e.NewVolume * 100).ToString(CultureInfo.InvariantCulture);
        }

        private void _spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            double timeLeft = (e.TrackTime - _currentTrack.Length) * -1;
            //timeLabel.Text = $"{FormatTime(e.TrackTime)}/{FormatTime(_currentTrack.Length)}";
            timeLabel.Text = $"{FormatTime(timeLeft)}";
            timeProgressBar.Value = (int)e.TrackTime;
        }

        private void _spotify_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            UpdateTrack(e.NewTrack);

            albumMarquee.Enabled = false;
            artistMarquee.Enabled = false;
            titleMarquee.Enabled = false;
            titleLinkLabel.Location = trackLLoc;
            trackRight.Location = trackRLoc;
            artistLinkLabel.Location = artistLLoc;
            artistRight.Location = artistRLoc;
            albumLinkLabel.Location = albumLLoc;
            albumRight.Location = albumRLoc;
        }

        private void _spotify_OnPlayStateChange(object sender, PlayStateEventArgs e)
        {
            UpdatePlayingStatus(e.Playing);
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            if (isPlayingLabel.Text == "True")
            {
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.play1;
                _spotify.Pause();
            }
            else
            {
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pause1;
                _spotify.Play();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _spotify.Previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _spotify.Skip();
        }

        private void btnPrev_MouseEnter(object sender, EventArgs e)
        {
            btnPrev.Image = SpotifyMiniPlayer.Properties.Resources.prevBig;
        }
        private void btnPrev_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrev.Image = SpotifyMiniPlayer.Properties.Resources.prev3;
        }
        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {
            btnPrev.Image = SpotifyMiniPlayer.Properties.Resources.prev1;
        }
        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.Image = SpotifyMiniPlayer.Properties.Resources.nextBig;
        }
        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            btnNext.Image = SpotifyMiniPlayer.Properties.Resources.next3;
        }
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Image = SpotifyMiniPlayer.Properties.Resources.next1;
        }
        private void btnPlayPause_MouseEnter(object sender, EventArgs e)
        {
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pauseBig;
            else btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.playBig;
        }
        private void btnPlayPause_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pause3;
            else btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.play3;
        }
        private void btnPlayPause_MouseLeave(object sender, EventArgs e)
        {
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.pause1;
            else btnPlayPause.Image = SpotifyMiniPlayer.Properties.Resources.play1;
        }
        //private void btnExit_MouseEnter(object sender, EventArgs e)
        //{
        //    btnExit.Image = SpotifyMiniPlayer.Properties.Resources.exit2;
        //}
        //private void btnExit_MouseLeave(object sender, EventArgs e)
        //{
        //    btnExit.Image = SpotifyMiniPlayer.Properties.Resources.exit;
        //}
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    btnExit.Image = SpotifyMiniPlayer.Properties.Resources.exit;
        //    Application.Exit();
        //}

        private void titleLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            titleLinkLabel.LinkColor = System.Drawing.Color.White;
            titleMarquee.Enabled = true;
        }
        private void artistLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            artistLinkLabel.LinkColor = System.Drawing.Color.White;
        }
        private void albumLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            albumLinkLabel.LinkColor = System.Drawing.Color.White;
            albumMarquee.Enabled = true;
        }
        private void titleLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            titleLinkLabel.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }
        private void artistLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            artistLinkLabel.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }
        private void albumLinkLabel_MouseLeave(object sender, EventArgs e)
        {
            albumLinkLabel.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }
        private void trackRight_MouseEnter(object sender, EventArgs e)
        {
            trackRight.LinkColor = System.Drawing.Color.White;
        }
        private void trackRight_MouseLeave(object sender, EventArgs e)
        {
            trackRight.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }
        private void artistRight_MouseEnter(object sender, EventArgs e)
        {
            artistRight.LinkColor = System.Drawing.Color.White;
        }
        private void artistRight_MouseLeave(object sender, EventArgs e)
        {
            artistRight.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }

        private void albumRight_MouseEnter(object sender, EventArgs e)
        {
            albumRight.LinkColor = System.Drawing.Color.White;
        }
        private void albumRight_MouseLeave(object sender, EventArgs e)
        {
            albumRight.LinkColor = System.Drawing.Color.FromArgb(175, 175, 175);
        }

        //private void volUp_Click(object sender, EventArgs e)
        //{
        //}

        //private void volDown_Click(object sender, VolumeChangeEventArgs e, EventArgs f)
        //{
        //    e.NewVolume -= 10;

        //}

        private static String FormatTime(double sec)
        {
            TimeSpan span = TimeSpan.FromSeconds(sec);
            String secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }

        private void titleMarquee_Tick(object sender, EventArgs e)
        {
            //if text width is larger than mini-player, was 270 now 245 now 260
            if (titleLinkLabel.Width > 150)
            {
                titleLinkLabel.Location = new Point(titleLinkLabel.Location.X - 1, titleLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text -- was 25 changed to 45
                if (titleLinkLabel.Right <= 130)
                {
                    trackRight.Location = new Point(trackRight.Location.X - 1, trackRight.Location.Y);
                    if (trackRight.Left <= 3)
                    {
                        titleMarquee.Enabled = false;
                        titleLinkLabel.Location = trackLLoc;
                        trackRight.Location = trackRLoc;
                    }
                }
                //if text fits, quit
            }
            else
            {
                titleMarquee.Enabled = false;

            }

        }

        private void artistMarquee_Tick(object sender, EventArgs e)
        {
            //if text width is larger than mini-player, was 270 now 245 now 260
            if (artistLinkLabel.Width > 150)
            {
                artistLinkLabel.Location = new Point(artistLinkLabel.Location.X - 1, artistLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text -- was 25 changed to 45
                if (artistLinkLabel.Right <= 130)
                {
                    albumRight.Location = new Point(albumRight.Location.X - 1, albumRight.Location.Y);
                    if (albumRight.Left <= 3)
                    {
                        artistMarquee.Enabled = false;
                        artistLinkLabel.Location = artistLLoc;
                        albumRight.Location = artistRLoc;
                    }
                }
                //if text fits, quit
            }
            else
            {
                artistMarquee.Enabled = false;

            }

        }

        private void albumMarquee_Tick(object sender, EventArgs e)
        {
            //if text width is larger than mini-player, was 270 now 245 now 260
            if (albumLinkLabel.Width > 150)
            {
                albumLinkLabel.Location = new Point(albumLinkLabel.Location.X - 1, albumLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text -- was 25 changed to 45
                if (albumLinkLabel.Right <= 130)
                {
                    albumRight.Location = new Point(albumRight.Location.X - 1, albumRight.Location.Y);
                    if (albumRight.Left <= 3)
                    {
                        albumMarquee.Enabled = false;
                        albumLinkLabel.Location = albumLLoc;
                        albumRight.Location = albumRLoc;
                    }
                }
                //if text fits, quit
            }
            else
            {
                albumMarquee.Enabled = false;

            }

        }

        private bool mouseDown;
        private Point lastLocation;

        private void LocalControl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LocalControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                ExampleForm.ActiveForm.Location = new Point(
                    (ExampleForm.ActiveForm.Location.X - lastLocation.X) + e.X, (ExampleForm.ActiveForm.Location.Y - lastLocation.Y) + e.Y);

                ExampleForm.ActiveForm.Update();
            }
        }

        private void LocalControl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LocalControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}