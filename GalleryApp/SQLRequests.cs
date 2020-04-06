using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GalleryApp
{
    class SQLRequests
    {
        public static List<YearFolder> selectAllFromYearFolder()
        {
            string queryString = "SELECT *  FROM YearFolder";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";
            List<YearFolder> years = new List<YearFolder>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
                try
                {
                    while (reader.Read())
                    {
                        YearFolder yearFolder = new YearFolder();
                        yearFolder.Year = Int32.Parse(String.Format("{0}", reader["Year"]));
                        years.Add(yearFolder);
                        i++;
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
                connection.Close();
            }
            return years;
        }

        public static void insertIntoPhotos(String folder, String photo)
        {
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            string query = "INSERT INTO Photos (Folder, Name, FullPath) VALUES (@Folder, @Name, @FullPath)";
            string fileName = new FileInfo(photo).Name;
            SqlConnection connection = new SqlConnection(connectionID);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Folder", folder);
                command.Parameters.AddWithValue("@Name", fileName);
                command.Parameters.AddWithValue("@FullPath", photo);

                connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
            connection.Close();
        }

        public static bool isYearExisting(int year)
        {
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            string query = "SELECT * FROM YearFolder WHERE [Year]=@Year";
            SqlConnection connection = new SqlConnection(connectionID);
            int i = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Year", year);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    i++;
            }
            connection.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool isFolderExisting(String fullPath)
        {
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Folder WHERE [FullPath]=@FullPath";
            SqlConnection connection = new SqlConnection(connectionID);
            int i = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@FullPath", fullPath);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    i++;
            }
            connection.Close();
            if (i > 0)
                return true;
            else
                return false;
        }
        public static bool isFolderExisting(String name, int year)
        {
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            string query = "SELECT * FROM Folder WHERE [Name]=@Name AND [Year]=year";
            SqlConnection connection = new SqlConnection(connectionID);
            int i = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Year", year);   
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    i++;
            }
            connection.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public static void insertNewFolder(String fullPath, int year, String place)
        {
            string dirName = new DirectoryInfo(fullPath).Name;
            string query = "INSERT INTO Folder (Year, Name, FullPath, Place) VALUES (@Year, @Name, @FullPath, @Place)";
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionID))
            {
                if (!isYearExisting(year))
                {
                    string queryYear = "INSERT INTO YearFolder (Year) VALUES (@Year)";
                    using (SqlCommand command = new SqlCommand(queryYear, connection))
                    {
                        command.Parameters.AddWithValue("@Year", year);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                    }
                }
                connection.Close();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Name", dirName);
                    command.Parameters.AddWithValue("@FullPath", fullPath);
                    command.Parameters.AddWithValue("@Place", place);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
            loadPhotosInDB(fullPath, dirName);
        }

        public static String[] getFilesFrom(String searchFolder, String[] filters)
        {
            List<String> filesFound = new List<String>();
            //var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), SearchOption.AllDirectories));
            }
            return filesFound.ToArray();
        }

        public static void loadPhotosInDB(String fullPath, String folder)
        {
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
            String[] photos = getFilesFrom(fullPath, filters);
            foreach (String photo in photos)
            {
                SQLRequests.insertIntoPhotos(fullPath, photo);
            }
        }

        public static List<Photos> selectImagesFromFolder(String folder, int year)
        {
            List<Photos> res = new List<Photos>();
            String query = @"SELECT * FROM Photos 
            INNER JOIN Folder ON Photos.Folder = Folder.FullPath 
            WHERE Folder.Name = @Folder AND Folder.Year = @Year";
            string connectionID = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionID);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Folder", folder);
                command.Parameters.AddWithValue("@Year", year);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Photos photos = new Photos();
                    photos.FullPath = String.Format("{0}", reader["FullPath"]);
                    photos.Name = String.Format("{0}", reader["Name"]);
                    photos.Folder = String.Format("{0}", reader["Folder"]);
                    photos.Alias = String.Format("{0}", reader["Alias"]);
                    res.Add(photos);
                }
            }
            connection.Close();
            return res;
        }

        public static Photos selectOneImage(String folder, String name)
        {
            string query = @"SELECT * FROM Photos 
            INNER JOIN Folder ON Photos.Folder = Folder.FullPath 
            WHERE Folder.Name = @folder AND Photos.Name = @name";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";
            Photos pic = new Photos();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@folder", folder);
                command.Parameters.AddWithValue("@name", name);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        pic.Folder = String.Format("{0}", reader["Folder"]);
                        pic.Name = String.Format("{0}", reader["Name"]);
                        pic.FullPath = String.Format("{0}", reader["FullPath"]);
                        pic.Alias = String.Format("{0}", reader["Alias"]);
                    }
                }                
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
                connection.Close();
            }
            return pic;
        }

        public static Folder selectParentFolder(Photos photo)
        {
            Folder folder = new GalleryApp.Folder();

            string query = @"SELECT * FROM Folder 
            INNER JOIN Photos ON Photos.Folder = Folder.FullPath
            WHERE Folder.FullPath = @folder";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@folder", photo.Folder);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        folder.Place = String.Format("{0}", reader["Place"]);
                        folder.Name = String.Format("{0}", reader["Name"]);
                        folder.FullPath = String.Format("{0}", reader["FullPath"]);
                        folder.Year = Int32.Parse(String.Format("{0}", reader["Year"]));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
                connection.Close();
            }

            return folder;
        }

        public static int updatePhotoAlias(string newPath, string oldPath)
        {
            string query = @"UPDATE Photos 
            SET Photos.Alias = @alias
            WHERE Photos.FullPath = @fullPath";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";
            Photos pic = new Photos();
            int result = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@alias", newPath);
                command.Parameters.AddWithValue("@fullPath", oldPath);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }

        public static int deletePhotoAlias()
        {
            string query = @"UPDATE Photos 
            SET Photos.Alias = NULL";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";
            Photos pic = new Photos();
            int result = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }

        public static int deleteFolder(String folder, int year)
        {
            string query = @"DELETE Photos FROM Photos 
            INNER JOIN Folder ON Photos.Folder = Folder.FullPath
            WHERE Folder.Name = @folder AND Folder.Year = @year";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True";
            int result = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@folder", folder);
                command.Parameters.AddWithValue("@year", year);
                connection.Open();
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            if (result >= 0)
            {
                query = @"DELETE FROM Folder 
                WHERE Folder.Name = @folder AND Folder.Year = @year";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@folder", folder);
                    command.Parameters.AddWithValue("@year", year);
                    connection.Open();
                    result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            int nb = 1;
            if (result >= 0)
            {
                query = @"SELECT COUNT(Year) FROM Folder
                WHERE Year = @year";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@year", year);
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            nb = Int32.Parse(String.Format("{0}", reader[""]));
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                    connection.Close();                   
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (nb == 0)
                    {
                        query = @"DELETE FROM YearFolder WHERE Year = @year";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@year", year);
                        connection.Open();
                        result = command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            return result;
        }
    }
}
