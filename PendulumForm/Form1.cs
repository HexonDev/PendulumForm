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

            albumCB.SelectedText = String.Empty;
            albumCB.SelectedIndex = -1;
            albumCB.Text = String.Empty;

            tracksDGV.Rows.Clear();
            addUrlBTN.Enabled = false;
            editBTN.Enabled = false;
            searchTB.Enabled = false;
            coverPB.Image = null;
            linkLBL.Text = String.Empty;

            artistCB.Items.Clear();
            foreach (var artist in artists)
            {
                artistCB.Items.Add(artist.Name);
            }
        }

        private void artistCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            coverPB.Image = null;
            detailsRTB.Text = String.Empty;

            selectedAlbums = Album.GetAlbumsByArtistName(artistCB.Text, albums);

            albumCB.Items.Clear();
            foreach (var album in selectedAlbums)
            {
                albumCB.Items.Add(album.Title);
            }

            albumCB.SelectedText = String.Empty;
            albumCB.SelectedIndex = -1;
            albumCB.Text = String.Empty;

            tracksDGV.Rows.Clear();
            addUrlBTN.Enabled = false;
            editBTN.Enabled = false;

            if (tracksDGV.RowCount > 0)
                searchTB.Enabled = true;
            else
                searchTB.Enabled = false;
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
                              $"Teljes hossz: {fullLength.ToString()}";


            tracksDGV.Rows.Clear();
            foreach (var track in selectedTracks)
            {
                tracksDGV.Rows.Add(track.Title, track.Length.ToString());
            }

            coverPB.Image = (Image)Resources.ResourceManager.GetObject(selectedAlbum.Id);

            if (tracksDGV.RowCount > 0)
                searchTB.Enabled = true;
            else
                searchTB.Enabled = false;
        }


        private void addUrlBTN_Click(object sender, EventArgs e)
        {
            LinkForm linkForm = new LinkForm();

            if (linkForm.ShowDialog() == DialogResult.OK)
            {
                string trackTitle = tracksDGV.CurrentRow.Cells[0].Value.ToString();
                var track = Track.GetTrackByTitle(trackTitle, tracks);

                track.TinyURL = linkForm.URL;
                linkLBL.Text = "https://youtu.be/" + track.TinyURL;
                track.SaveToDatabase();

                linkForm.Close();
            }

            linkForm.Dispose();
        }

        private void tracksDGV_SelectionChanged(object sender, EventArgs e)
        {
            string trackTitle = tracksDGV.CurrentRow.Cells[0].Value.ToString();
            var track = Track.GetTrackByTitle(trackTitle, tracks);

            if (track?.TinyURL == "null")
            {
                linkLBL.Text = String.Empty;
            }
            else
            {
                linkLBL.Text = "https://youtu.be/" + track?.TinyURL;
            }

            editBTN.Enabled = true;
            addUrlBTN.Enabled = true;
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            string trackTitle = tracksDGV.CurrentRow.Cells[0].Value.ToString();
            var track = Track.GetTrackByTitle(trackTitle, tracks);

            editForm.urlTB.Text = track.TinyURL;
            editForm.albumTB.Text = track.AlbumId;
            editForm.lengthTB.Text = track.Length.ToString();
            editForm.titleTB.Text = track.Title;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                

                track.Length = editForm.length;
                track.Title = editForm.titleTB.Text;
                track.AlbumId = editForm.albumTB.Text;
                track.TinyURL = editForm.urlTB.Text;

                track.SaveToDatabase();

                ReloadData();


                editForm.Close();
            }

            editForm.Dispose();
        }
    }
}
