using System;
using System.Data.SQLite;
using System.IO;

namespace UnicomTIC_UMS.Database
{
    public static class DatabaseConnection
    {
        public static SQLiteConnection GetConnection()
        {
            string folder = @"C:\Users\arspi\Documents\c sharp project\UnicomTIC_UMS\UnicomTIC_UMS\Database";
            string fileName = "UMS.db";

            string dbPath = Path.Combine(folder, fileName); // Correct
            string connectionString = $"Data Source={dbPath};Version=3;";

            return new SQLiteConnection(connectionString);
        }

    }
}
