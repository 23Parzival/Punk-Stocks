using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Data
{
    internal static class Database
    {
        private static readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Punk-Stocks", "punkstocks.db");

        public static string DbPath
        {
            get { return dbPath; }
        }

        public static SqliteConnection GetConnection()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

            var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }
            return connection;
        }
    }
}
