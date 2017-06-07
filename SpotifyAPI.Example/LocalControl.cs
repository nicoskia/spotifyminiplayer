using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace SpotifyAPI.Example
{
    public partial class LocalControl : UserControl
    {
        private readonly SpotifyLocalAPI _spotify;
        private readonly SpotifyAPI.Web.SpotifyWebAPI _spotifyWEB;
        private Track _currentTrack;
        public Point trackLLoc = new System.Drawing.Point(86, 6);
        public Point trackRLoc = new System.Drawing.Point(260, 6);
        public Point artistLLoc = new System.Drawing.Point(86, 25);
        public Point artistRLoc = new System.Drawing.Point(260, 25);
        public Point albumLLoc = new System.Drawing.Point(86, 42);
        public Point albumRLoc = new System.Drawing.Point(260, 42);


        public LocalControl()
        {
            InitializeComponent();

            _spotify = new SpotifyLocalAPI();
            _spotifyWEB = new SpotifyAPI.Web.SpotifyWebAPI();
            _spotify.OnPlayStateChange += _spotify_OnPlayStateChange;
            _spotify.OnTrackChange += _spotify_OnTrackChange;
            _spotify.OnTrackTimeChange += _spotify_OnTrackTimeChange;
            _spotify.OnVolumeChange += _spotify_OnVolumeChange;
            //_spotify.SynchronizingObject = this;

            artistLinkLabel.Click += (sender, args) => Process.Start(artistLinkLabel.Tag.ToString());
            albumLinkLabel.Click += (sender, args) => Process.Start(albumLinkLabel.Tag.ToString());
            titleLinkLabel.Click += (sender, args) => Process.Start(titleLinkLabel.Tag.ToString());

            //SpotifyAPI.Example.WebControl.RunAuthorization();
            Connect();
        }

        //private void RunAuthentication()
        //{
        //    throw new NotImplementedException();
        //}

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
                
                //connectBtn.Text = @"Connection to Spotify successful";
                //connectBtn.Enabled = false;
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
            //clientVersionLabel.Text = status.ClientVersion;
            //versionLabel.Text = status.Version.ToString();
            //repeatShuffleLabel.Text = status.Repeat + @" and " + status.Shuffle;

            if (status.Track != null) //Update track infos
                UpdateTrack(status.Track);

            if (isPlayingLabel.Text == "True")
            {
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.pause1;
            }
            else
            {
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.play1;
            }
        }

        public async void UpdateTrack(Track track)
        {
            _currentTrack = track;

            advertLabel.Text = track.IsAd() ? "ADVERT" : "";
            timeProgressBar.Maximum = track.Length;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            titleLinkLabel.Text = track.TrackResource.Name;
            titleLinkLabel.Tag = track.TrackResource.Uri;
            trackRight.UseMnemonic = false;
            trackRight.Text = track.TrackResource.Name;
            trackRight.Tag = track.TrackResource.Uri;

            artistLinkLabel.Text = track.ArtistResource.Name;
            artistLinkLabel.Tag = track.ArtistResource.Uri;
            artistRight.UseMnemonic = false;
            artistRight.Text = track.ArtistResource.Name;
            artistRight.Tag = track.ArtistResource.Uri;


            albumLinkLabel.Text = track.AlbumResource.Name;
            albumLinkLabel.Tag = track.AlbumResource.Uri;
            albumRight.UseMnemonic = false;
            albumRight.Text = track.AlbumResource.Name;
            albumRight.Tag = track.AlbumResource.Uri;

            SpotifyUri uri = track.TrackResource.ParseUri();

            //trackInfoBox.Text = $@"Track Info - {uri.Id}";

            //bigAlbumPicture.Image = await track.GetAlbumArtAsync(AlbumArtSize.Size640);
            smallAlbumPicture.Image = await track.GetAlbumArtAsync(AlbumArtSize.Size160);
        }

        public void UpdatePlayingStatus(bool playing)
        {
            isPlayingLabel.Text = playing.ToString();
        }

        private void _spotify_OnVolumeChange(object sender, VolumeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnVolumeChange(sender, e)));
                return;
            }
            //volumeLabel.Text = (e.NewVolume * 100).ToString(CultureInfo.InvariantCulture);
        }

        private void _spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackTimeChange(sender, e)));
                return;
            }
            timeTotal.Text = $@"{FormatTime(_currentTrack.Length)}";
            timeLeft.Text = $@"{FormatTime(e.TrackTime)}";
            if(e.TrackTime < _currentTrack.Length)
                timeProgressBar.Value = (int)e.TrackTime;
        }

        private void _spotify_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackChange(sender, e)));
                return;
            }
            UpdateTrack(e.NewTrack);
            UpdateInfos();
        }

        private void _spotify_OnPlayStateChange(object sender, PlayStateEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnPlayStateChange(sender, e)));
                return;
            }
            UpdatePlayingStatus(e.Playing);
            UpdateInfos();
        }

        //private async void playUrlBtn_Click(object sender, EventArgs e)
        //{
        //    await _spotify.PlayURL(playTextBox.Text, contextTextBox.Text);
        //}

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Image = SpotifyAPI.Example.Properties.Resources.exit2;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = SpotifyAPI.Example.Properties.Resources.exit1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Image = SpotifyAPI.Example.Properties.Resources.exit1;
            Application.Exit();
        }

        private void btnPlayPause_MouseEnter(object sender, EventArgs e)
        {
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.pause2;
            else btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.play2;
        }
        private void btnPlayPause_MouseLeave(object sender, EventArgs e)
        {
            if (isPlayingLabel.Text == "True")
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.pause1;
            else btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.play1;
        }

        private async void btnPlayPause_Click(object sender, EventArgs e)
        {

            if (isPlayingLabel.Text == "True")
            {
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.play1;
                await _spotify.Pause();
            }
            else
            {
                btnPlayPause.Image = SpotifyAPI.Example.Properties.Resources.pause1;
                await _spotify.Play();
            }
        }

        private void titleLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            titleMarquee.Enabled = true;
        }
        private void artistLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            artistMarquee.Enabled = true;
        }
        private void albumLinkLabel_MouseEnter(object sender, EventArgs e)
        {
            albumMarquee.Enabled = true;
        }

        private async void playBtn_Click(object sender, EventArgs e)
        {
            await _spotify.Play();
        }

        private async void pauseBtn_Click(object sender, EventArgs e)
        {
            await _spotify.Pause();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            _spotify.Previous();
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

        private void skipBtn_Click(object sender, EventArgs e)
        {
            _spotify.Skip();
            albumMarquee.Enabled = false;
            artistMarquee.Enabled = false;
            titleMarquee.Enabled = false;
            titleLinkLabel.Location = trackLLoc;
            trackRight.Location = trackRLoc;
            albumLinkLabel.Location = albumLLoc;
            albumRight.Location = albumRLoc;
        }

        private void prevBtn_MouseEnter(object sender, EventArgs e)
        {
            prevBtn.Image = SpotifyAPI.Example.Properties.Resources.prev2;
        }
        private void prevBtn_MouseLeave(object sender, EventArgs e)
        {
            prevBtn.Image = SpotifyAPI.Example.Properties.Resources.prev1;
        }
        private void skipBtn_MouseEnter(object sender, EventArgs e)
        {
            skipBtn.Image = SpotifyAPI.Example.Properties.Resources.next2;
        }
        private void skipBtn_MouseLeave(object sender, EventArgs e)
        {
            skipBtn.Image = SpotifyAPI.Example.Properties.Resources.next1;
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            saveBtn.Image = SpotifyAPI.Example.Properties.Resources.plus2;
        }
        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.Image = SpotifyAPI.Example.Properties.Resources.plus;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _spotifyWEB.SaveTrack(_currentTrack.TrackResource.Uri);
        }

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
            //if text width is larger than mini-player
            if (titleLinkLabel.Width > 145)
            {
                titleLinkLabel.Location = new Point(titleLinkLabel.Location.X - 1, titleLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text
                if (titleLinkLabel.Right <= 250)
                {
                    trackRight.Location = new Point(trackRight.Location.X - 1, trackRight.Location.Y);
                    if (trackRight.Left <= 86)
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
            //if text width is larger than mini-playe
            if (artistLinkLabel.Width > 150)
            {
                artistLinkLabel.Location = new Point(artistLinkLabel.Location.X - 1, artistLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text
                if (artistLinkLabel.Right <= 250)
                {
                    albumRight.Location = new Point(albumRight.Location.X - 1, albumRight.Location.Y);
                    if (albumRight.Left <= 86)
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
            //if text width is larger than mini-player
            if (albumLinkLabel.Width > 150)
            {
                albumLinkLabel.Location = new Point(albumLinkLabel.Location.X - 1, albumLinkLabel.Location.Y);
                //start scrolling
                //when right edge of text moves far enough, start scrolling new text
                if (albumLinkLabel.Right <= 250)
                {
                    albumRight.Location = new Point(albumRight.Location.X - 1, albumRight.Location.Y);
                    if (albumRight.Left <= 86)
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

        //private void timeProgressBar_Click(object sender, TrackTimeChangeEventArgs e)
        //{
            // Get mouse position(x) minus the width of the progressbar (so beginning of the progressbar is mousepos = 0 //
        //    float absoluteMouse = (PointToClient(MousePosition).X - timeProgressBar.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
        //    float calcFactor = timeProgressBar.Width / (float)100;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
        //    float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //
        //    e.TrackTime = Convert.ToInt32(relativeMouse);
        //    timeProgressBar.Value = Convert.ToInt32(relativeMouse);
        //}
    }
}