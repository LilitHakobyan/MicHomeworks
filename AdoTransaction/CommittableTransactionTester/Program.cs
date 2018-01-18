using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CommittableTransactionTester
{
    class Program
    {
        const string connectionString =
            "Data Source=192.168.107.14;" +
            "Initial Catalog = FirstLessonTestDB; " +
            "Integrated Security = True";

        private static void UpdateProducts(int id, CommittableTransaction transaction)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.EnlistTransaction(transaction);
                SqlCommand command =
                    new SqlCommand($"Insert into Person([First name], Age) Values('test{id}', 10)", connection);

                command.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            CommittableTransaction transaction = new CommittableTransaction();
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    UpdateProducts(i, transaction);
                }

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }
}
