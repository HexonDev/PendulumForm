using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    class Album
    {
        public string Id { get; }
        public string Artist { get; }
        public string Title { get; }
        public DateTime Release { get; }

        public Album(string id, string artist, string title, DateTime release)
        {
            Id = id;
            Artist = artist;
            Title = title;
            Release = release;
        }

        public static List<Album> LoadAllFromDatabase()
        {
            var albums = new List<Album>();
            var conn = Database.Connection;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Albums", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                albums.Add(new Album((string) reader["id"], (string) reader["artist"], (string) reader["title"], (DateTime) reader["release"]));
            }

    
            conn.Close();

            return albums;
        }

        public static List<Album> GetAlbumsByArtistName(string artistName, ICollection<Album> albums)
        {
            var b = albums.Where(a => a.Artist == artistName).ToList();
            return b;
        }

        public static Album GetByTitle(string albumTitle, ICollection<Album> albums)
        {
            return albums.SingleOrDefault(a => a.Title == albumTitle);
        }
    }
}
