using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TransactionScopeTester
{
    class Program
    {
        const string connectionString =
            "Data Source=192.168.107.14;" +
            "Initial Catalog = FirstLessonTestDB; " +
            "Integrated Security = True";

        private static void UpdateProducts(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (id == 5)
                    throw new Exception();

                connection.Open();
                SqlCommand command =
                    new SqlCommand($"Insert into Person([First name], Age) Values('test{id}', 10)", connection);

                command.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                for (int i = 1; i < 10; i++)
                {
                    UpdateProducts(i);
                }

                scope.Complete();
            }
        }
    }
}
