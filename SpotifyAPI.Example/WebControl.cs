﻿using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace SpotifyAPI.Example
{
    public partial class WebControl : UserControl
    {
        public SpotifyWebAPI _spotify;

        public PrivateProfile _profile;
        public List<FullTrack> _savedTracks;
        public List<SimplePlaylist> _playlists;

        public WebControl()
        {
            InitializeComponent();

            _savedTracks = new List<FullTrack>();
            
        }

        public async void InitialSetup()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(InitialSetup));
                return;
            }

            authButton.Enabled = false;
            _profile = await _spotify.GetPrivateProfileAsync();

            _savedTracks = GetSavedTracks();
            savedTracksCountLabel.Text = _savedTracks.Count.ToString();
            _savedTracks.ForEach(track => savedTracksListView.Items.Add(new ListViewItem()
            {
                Text = track.Name,
                SubItems = { string.Join(",", track.Artists.Select(source => source.Name)), track.Album.Name }
            }));

            _playlists = GetPlaylists();
            playlistsCountLabel.Text = _playlists.Count.ToString();
            _playlists.ForEach(playlist => playlistsListBox.Items.Add(playlist.Name));

            displayNameLabel.Text = _profile.DisplayName;
            countryLabel.Text = _profile.Country;
            emailLabel.Text = _profile.Email;
            accountLabel.Text = _profile.Product;

            if (_profile.Images != null && _profile.Images.Count > 0)
            {
                using (WebClient wc = new WebClient())
                {
                    byte[] imageBytes = await wc.DownloadDataTaskAsync(new Uri(_profile.Images[0].Url));
                    using (MemoryStream stream = new MemoryStream(imageBytes))
                        avatarPictureBox.Image = Image.FromStream(stream);
                }
            }
        }

        public List<FullTrack> GetSavedTracks()
        {
            Paging<SavedTrack> savedTracks = _spotify.GetSavedTracks();
            List<FullTrack> list = savedTracks.Items.Select(track => track.Track).ToList();

            while (savedTracks.Next != null)
            {
                savedTracks = _spotify.GetSavedTracks(20, savedTracks.Offset + savedTracks.Limit);
                list.AddRange(savedTracks.Items.Select(track => track.Track));
            }

            return list;
        }

        public List<SimplePlaylist> GetPlaylists()
        {
            Paging<SimplePlaylist> playlists = _spotify.GetUserPlaylists(_profile.Id);
            List<SimplePlaylist> list = playlists.Items.ToList();

            while (playlists.Next != null)
            {
                playlists = _spotify.GetUserPlaylists(_profile.Id, 20, playlists.Offset + playlists.Limit);
                list.AddRange(playlists.Items);
            }

            return list;
        }

        public void authButton_Click(object sender, EventArgs e)
        {
            //Task.Run(() => RunAuthentication());
        }

        public async void RunAuthentication()
        {
            WebAPIFactory webApiFactory = new WebAPIFactory(
                "http://localhost",
                8000,
                "26d287105e31491889f3cd293d85bfea",
                Scope.UserReadPrivate | Scope.UserReadEmail | Scope.PlaylistReadPrivate | Scope.UserLibraryRead |
                Scope.UserReadPrivate | Scope.UserFollowRead | Scope.UserReadBirthdate | Scope.UserTopRead | Scope.PlaylistReadCollaborative |
                Scope.UserReadRecentlyPlayed | Scope.UserReadPlaybackState | Scope.UserModifyPlaybackState);

            try
            {
                _spotify = await webApiFactory.GetWebApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (_spotify == null)
                return;

            InitialSetup();
        }

    }
}