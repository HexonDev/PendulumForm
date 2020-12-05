using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendulumForm
{
    public static class Database
    {
        public static SqlConnection Connection;


        public static void Init(bool deleteLastRecords = false)
        {
            try
            {
                Connection = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB;
                            AttachDbFilename=|DataDirectory|\Resources\music.mdf;
                            Integrated Security=True;
                            Connect Timeout=5
                            ");
                // Leteszteljük a DB kapcsolatot
                Connection.Open();
                Connection.Close();

            }
            catch (Exception e)
            {
                Error.Show(e);
                throw;
            }

            try
            {
                string QueryString = GetSQLString(deleteLastRecords);

                Connection.Open();
                new SqlCommand(QueryString, Connection).ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Error.Show(e);
                throw;
            }
        }


        static string GetSQLString(bool delete = false)
        {
            if (delete)
            {
                return @"DROP TABLE IF EXISTS Tracks;
                    DROP TABLE IF EXISTS Albums;

                    CREATE TABLE Albums (
	                    id VARCHAR(4) PRIMARY KEY,
	                    artist VARCHAR(255) NOT NULL,
	                    title VARCHAR(255) NOT NULL,
	                    release DATE
                    );

                    CREATE TABLE Tracks (
	                    id INT PRIMARY KEY IDENTITY,
	                    title VARCHAR(255) NOT NULL,
	                    length TIME,
	                    album VARCHAR(4) FOREIGN KEY REFERENCES Albums(Id),
	                    url VARCHAR(30) 
                    );";
            }
            else
            {
                return @"

                    IF OBJECT_ID('Albums', 'U') IS NULL CREATE TABLE Albums (
	                    id VARCHAR(4) PRIMARY KEY,
	                    artist VARCHAR(255) NOT NULL,
	                    title VARCHAR(255) NOT NULL,
	                    release DATE
                    );

                    IF OBJECT_ID('Tracks', 'U') IS NULL CREATE TABLE Tracks (
	                    id INT PRIMARY KEY IDENTITY,
	                    title VARCHAR(255) NOT NULL,
	                    length TIME,
	                    album VARCHAR(4) FOREIGN KEY REFERENCES Albums(Id),
	                    url VARCHAR(30) 
                    );";
            }

        }
    }
}
