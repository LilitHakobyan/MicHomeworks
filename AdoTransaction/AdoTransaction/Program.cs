using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTransaction
{
    class Program
    {
        const string connectionString =
            "Data Source=192.168.107.14;" +
            "Initial Catalog = FirstLessonTestDB; " +
            "Integrated Security = True";

        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insert1 = "Insert into Person([First name], Age) Values('test1', 10)";

                    SqlCommand command = new SqlCommand(insert1, connection);
                    command.Transaction = transaction;

                    command.ExecuteNonQuery();

                    //throw new Exception();

                    string insert2 = "Insert into Person([First name], Age) Values('test2', 10)";

                    command = new SqlCommand(insert2, connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
