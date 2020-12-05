using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    class Discography
    {
        private string FilePath;

        public List<Album> Albums;
        public List<Track> Tracks;

        public Discography(string filePath)
        {
            FilePath = filePath;

            Albums = new List<Album>();
            Tracks = new List<Track>();
        }

        public void Process()
        {
            var sr = new StreamReader(FilePath);

            try
            {
                string currentAttribute = String.Empty;

                while (!sr.EndOfStream)
                {
                    string dataLine = sr.ReadLine();

                    if (dataLine == "[albums]" || dataLine == "[tracks]")
                    {
                        currentAttribute = dataLine;
                    }

                    if (!LineIsAttribute(dataLine))
                    {
                        string[] data = dataLine.Split(';');

                        if (currentAttribute == "[albums]")
                        {
                            string id = data[0];
                            string artist = data[1];
                            string title = data[2];
                            DateTime release = DateTime.Parse(data[3]);

                            Albums.Add(new Album(id, artist, title, release));
                        }
                        else if (currentAttribute == "[tracks]")
                        {
                            string title = data[0];
                            TimeSpan length = TimeSpan.Parse("00:" + data[1]);
                            string albumId = data[2];
                            string tinyURL = data[3];

                            Tracks.Add(new Track(title, length, albumId, tinyURL));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Error.Show(e);
                throw;
            }
        }

        public void SaveToDatabase()
        {
            try
            {
                SqlConnection conn = Database.Connection;
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                conn.Open();

                // Album paraméterek
                cmd.Parameters.Add("@id", SqlDbType.VarChar);
                cmd.Parameters.Add("@artist", SqlDbType.VarChar);
                cmd.Parameters.Add("@atitle", SqlDbType.VarChar);
                cmd.Parameters.Add("@release", SqlDbType.Date);

                foreach (var album in Albums)
                {
                    cmd.CommandText = "INSERT INTO Albums (id, artist, title, release) VALUES(@id, @artist, @atitle, @release)";
                    cmd.Parameters["@id"].Value = album.Id;
                    cmd.Parameters["@artist"].Value = album.Artist;
                    cmd.Parameters["@atitle"].Value = album.Title;
                    cmd.Parameters["@release"].Value = album.Release;

                    cmd.ExecuteNonQuery();
                }

                // Track paraméterek
                cmd.Parameters.Add("@ttitle", SqlDbType.VarChar);
                cmd.Parameters.Add("@length", SqlDbType.Time);
                cmd.Parameters.Add("@album", SqlDbType.VarChar);
                cmd.Parameters.Add("@url", SqlDbType.VarChar);

                foreach (var track in Tracks)
                {
                    cmd.CommandText = "INSERT INTO Tracks (title, length, album, url) VALUES(@ttitle, @length, @album, @url)";
                    cmd.Parameters["@ttitle"].Value = track.Title;
                    cmd.Parameters["@length"].Value = track.Length;
                    cmd.Parameters["@album"].Value = track.AlbumId;
                    cmd.Parameters["@url"].Value = track.TinyURL;

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Error.Show(e);
                throw;
            }
        }

        private bool LineIsAttribute(string line)
        {
            return line.Contains("[albums]") || line.Contains("[tracks]");
        }
    }
}
