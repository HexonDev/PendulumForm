using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    public partial class DiscographyForm : Form
    {
        private List<Artist> artists;
        private List<Track> tracks;
        private List<Album> albums;
        private List<Album> selectedAlbums;
        private List<Track> selectedTracks;

        public DiscographyForm()
        {
            InitializeComponent();
        }

        private void DiscographyForm_Load(object sender, EventArgs e)
        {
            Database.Init(false);
            ReloadData();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select discography file";
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Discography discography = new Discography(dialog.FileName);
                discography.Process();
                discography.SaveToDatabase();

                ReloadData();
            }
        }

        void ReloadData()
        {
            albums = Album.LoadAllFromDatabase();
            artists = Artist.LoadAllFromDatabase();
            tracks = Track.LoadAllFromDatabase();

            artistCB.Items.Clear();
            foreach (var artist in artists)
            {
                artistCB.Items.Add(artist.Name);
            }
        }

        private void artistCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbums = Album.GetAlbumsByArtistName(artistCB.Text, albums);

            albumCB.Items.Clear();
            foreach (var album in selectedAlbums)
            {
                albumCB.Items.Add(album.Title);
            }

            albumCB.SelectedText = String.Empty;
            albumCB.SelectedIndex = -1;
            albumCB.Text = String.Empty;
            
        }

        

        private void albumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAlbum = Album.GetByTitle(albumCB.Text, albums);
            selectedTracks = Track.GetTracksByAlbumId(selectedAlbum.Id, tracks);
            TimeSpan fullLength = new TimeSpan(0, 0, 0);

            foreach (var track in selectedTracks)
            {
                fullLength += track.Length;
            }

            detailsRTB.Text = $"Kiadási dátum: {selectedAlbum.Release.ToString("yyyy. MMMM dd.")}\n" +
                              $"Teljes hossz: {fullLength.ToString("h'h 'm'm 's's'")}";


            tracksDGV.Rows.Clear();
            foreach (var track in selectedTracks)
            {
                tracksDGV.Rows.Add(track.Title, track.Length.ToString("h'h 'm'm 's's'"));
            }

            coverPB.Image = (Image)Resources.ResourceManager.GetObject(selectedAlbum.Id);
        }

        private void tracksDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (albumCB.SelectedIndex > 0)
            {
                if (tracksDGV.CurrentRow?.Cells[0].Value != null)
                {
                    string trackTitle = tracksDGV.CurrentRow.Cells[0].Value.ToString();
                    var track = Track.GetTrackByTitle(trackTitle, tracks);

                    if (track.TinyURL == "null")
                    {
                        linkLBL.Text = String.Empty;
                    }
                    else
                    {
                        linkLBL.Text = "https://youtu.be/" + track.TinyURL;
                    }
                }

            }
            
        }
    }
}
