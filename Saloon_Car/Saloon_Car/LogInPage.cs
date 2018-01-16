using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Saloon_Car
{
    public partial class LogInPage : Form
    {
        public string Name { get; set; }
        private string Password { get; set; }
        public bool Role { get; set; }
        private Dictionary<string, string> passwordAndLogin = new Dictionary<string, string>();
        private string UserDataPath;
        private List<User> users = new List<User>();
        public LogInPage()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            using (SqlConnection connection = new SqlConnection(Utility.ConnectionString))
                {
                    connection.Open();

                    string sqlCommand = "Select * from UserT";
                    SqlCommand command = new SqlCommand(sqlCommand, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User useritem = new User()
                            {
                                Id = (int) reader["UserID"],
                                Name = reader["UserName"].ToString(),
                                Password = reader["UserPassword"].ToString(),
                                Role = (bool) reader["UserRole"]

                            };
                            users.Add(useritem);

                            passwordAndLogin.Add(useritem.Name, useritem.Password);
                        }
                    }
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            this.Name = this.textName.Text;
            // this.Password = this.textPassword.Text;
            string pass;
            if (passwordAndLogin.TryGetValue(this.textName.Text, out pass))
            {
                if (pass == this.textPassword.Text)
                {
                    this.Role = users.FirstOrDefault(user => user.Name == this.textName.Text && user.Password == this.textPassword.Text
                    ).Role;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Invalid password or login");
            }

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            this.Name = this.textName.Text;
            this.Password = this.textPassword.Text;
            Role = false;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(Utility.ConnectionString))
                    {

                        User user = new User()
                        {
                            Name = this.textName.Text,
                            Password = this.textPassword.Text,
                            Role = false
                        };
                        users.Add(user);

                        string sqlCommand =
                            "Insert into UserT(UserName,UserPassword,UserRole) Values(@uName,@uPasword,@uRole)";

                        SqlCommand command = new SqlCommand(sqlCommand, connection);
                        connection.Open();

                        command.Parameters.AddWithValue("uName", this.textName.Text);
                        command.Parameters.AddWithValue("uPasword", this.textPassword.Text);
                        command.Parameters.AddWithValue("uRole", 0);
                        command.ExecuteNonQuery();

                        passwordAndLogin.Add(Name, Password);
                        this.DialogResult = DialogResult.OK;
                        scope.Complete();
                    }

                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("User Name is exist");
            }
        catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void Cencel_Click(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
