using BlocknotSQLForms.Enitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocknotSQLForms
{
    public partial class FormCountries : Form
    {
        ICollection<Country> countries;

        public FormCountries()
        {
            InitializeComponent();

            countries = new BindingList<Country>();

            this.Load += FormCountries_Load;
        }

        private void FormCountries_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                connection.Open();

                string sqlCommand = "Select ID, Name as CountryName from Country";
                SqlCommand command = new SqlCommand(sqlCommand, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country country = new Country()
                        {
                            ID = (int)reader["ID"],
                            Name = reader["CountryName"].ToString()
                        };

                        countries.Add(country);
                    }
                }
            }

            this.dgvCountries.DataSource = countries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                Country c = new Country()
                {
                    Name = this.txtNewCountry.Text
                };

                string sqlCommand = "Insert into Country(Name) Values(@countryName)";

                SqlCommand command = new SqlCommand(sqlCommand, connection);
                connection.Open();

                command.Parameters.AddWithValue("countryName", this.txtNewCountry.Text);

                command.ExecuteNonQuery();

                this.countries.Add(c);
            }
        }
    }
}