using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumForm
{
    class Track
    {
        public int? Id { get; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string AlbumId { get; set; }
        public string TinyURL { get; set; }

        public Track(string title, TimeSpan lenght, string albumId, string url)
        {
            Title = title;
            Length = lenght;
            AlbumId = albumId;
            TinyURL = url;
        }

        public Track(int id, string title, TimeSpan lenght, string albumId, string url)
        {
            Id = id;
            Title = title;
            Length = lenght;
            AlbumId = albumId;
            TinyURL = url;
        }

        public void SaveToDatabase()
        {
            var conn = Database.Connection;

            SqlCommand cmd = new SqlCommand("UPDATE Tracks SET url = @newURL, title = @newTitle, length = @newLength, album = @newAlbum WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("newURL", TinyURL);
            cmd.Parameters.AddWithValue("newTitle", Title);
            cmd.Parameters.AddWithValue("newAlbum", AlbumId);
            cmd.Parameters.AddWithValue("newLength", Length);
            cmd.Parameters.AddWithValue("id", Id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Track> LoadAllFromDatabase()
        {
            var tracks = new List<Track>();
            var conn = Database.Connection;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tracks", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tracks.Add(new Track((int)reader["id"], (string)reader["title"], (TimeSpan)reader["length"], (string)reader["album"], (string)reader["url"]));
            }


            conn.Close();

            return tracks;
        }

        public static List<Track> GetTracksByAlbumId(string albumId, ICollection<Track> tracks)
        {
            return tracks.Where(t => t.AlbumId == albumId).ToList(); ;
        }

        public static Track GetTrackByTitle(string title, ICollection<Track> tracks)
        {
            return tracks.SingleOrDefault(t => t.Title == title);
        }
    }
}
