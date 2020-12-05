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
        public int Id { get; }
        public string Title { get; }
        public TimeSpan Length { get; }
        public string AlbumId { get; }
        public string TinyURL { get; }

        public Track(string title, TimeSpan lenght, string albumId, string url)
        {
            Title = title;
            Length = lenght;
            AlbumId = albumId;
            TinyURL = url;
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
                tracks.Add(new Track((string)reader["title"], (TimeSpan)reader["length"], (string)reader["album"], (string)reader["url"]));
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
