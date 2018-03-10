using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetADDReadeImageFromDB
{
    public class SavingAndReading
    {
        public void SaveFileToDatabase(string filename, string title)
        {
            string connectionString = Utility.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO ImageInfo VALUES (@FileName, @Title, @ImageData)";
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);

                // получаем короткое имя файла для сохранения в бд
                string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1); // cats.jpg
                // массив для хранения бинарных данных файла
                byte[] imageData;
                using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
                // передаем данные в команду через параметры
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@Title"].Value = title;
                command.Parameters["@ImageData"].Value = imageData;

                command.ExecuteNonQuery();
            }
        }
        public void ReadFileFromDatabase()
        {
            string connectionString = Utility.connectionString;
            List<ImageModel> images = new List<ImageModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM ImagesDB";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string filename = reader.GetString(1);
                    string title = reader.GetString(2);
                    byte[] data = (byte[])reader.GetValue(3);

                    ImageModel image = new ImageModel(id, filename, title, data);
                    images.Add(image);
                }
            }
            // сохраним первый файл из списка
            if (images.Count > 0)
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(images[0].FileName, FileMode.OpenOrCreate))
                {
                    fs.Write(images[0].Data, 0, images[0].Data.Length);
                    Console.WriteLine("Изображение '{0}' сохранено", images[0].Title);
                }
            }
        }
    }
}
