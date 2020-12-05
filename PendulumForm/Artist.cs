using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumForm
{
    class Artist
    {
        public string Name;

        public Artist(string name)
        {
            Name = name;
        }

        public static List<Artist> LoadAllFromDatabase()
        {
            var artists = new List<Artist>();
            var conn = Database.Connection;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT artist FROM Albums", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                artists.Add(new Artist((string) reader["artist"]));
            }


            conn.Close();

            return artists;
        }
    }
}
