using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Saloon_Car
{
    public partial class LogInPage : Form
    {
        public string Name { get; set; }
        private string Password { get; set; }
        public UserEnum Role { get; set; }
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
            UserDataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\users.log";
            if (!File.Exists(UserDataPath))
            {
                using (StreamWriter sw = File.CreateText(UserDataPath))
                {
                    sw.WriteLine('[');
                    sw.WriteLine(']');
                }
            }
            users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(UserDataPath));

            foreach (User itemUser in users)
            {
                passwordAndLogin.Add(itemUser.Name, itemUser.Password);
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

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            this.Name = this.textName.Text;
            this.Password = this.textPassword.Text;
            Role = UserEnum.User;
            try
            {
                passwordAndLogin.Add(Name, Password);
                User user = new User()
                {
                    Name = this.textName.Text,
                    Password = this.textPassword.Text,
                    Role = UserEnum.User
                };
                users.Add(user);
                string serializeString = JsonConvert.SerializeObject(users, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                File.WriteAllText(UserDataPath, serializeString);
                this.DialogResult = DialogResult.OK;
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"User name is exist");
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
