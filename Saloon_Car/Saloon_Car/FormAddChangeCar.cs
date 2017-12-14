using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saloon_Car
{
    public partial class FormAddChangeCar : Form
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ModelColor { get; set; }
        public double Price { get; private set; }
        public bool Search { get; private set; }

        public FormAddChangeCar(bool search = false)
        {
            InitializeComponent();
            this.Search = search;
            if (search)
            {
                this.txtPrice.Visible = false;
                this.labelPrice.Visible = false;
            }
        }
        public FormAddChangeCar(string brandName, string modelName, string modelColor, double price)
        {
            InitializeComponent();
            this.txtBrand.Text = brandName;
            this.txtModelName.Text = modelName;
            this.txtModelColor.Text = modelColor;
            this.txtPrice.Text = price.ToString();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.BrandName = this.txtBrand.Text;
            this.ModelName = this.txtModelName.Text;
            this.ModelColor = this.txtModelColor.Text;
            if (!Search)
            {
                if (this.BrandName == "" || this.ModelName == "" || this.ModelColor == ""|| this.txtPrice.Text=="")
                {
                    MessageBox.Show(@"Please fill in all the fields");
                }
                else
                {
                    if (CheckPrice(this.txtPrice.Text))
                    {
                        this.Price = double.Parse(this.txtPrice.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(@"Price has invalid format");
                    }
                }
            }
            else
            {
                if (this.BrandName == "" || this.ModelName == "" || this.ModelColor == "" )
                {
                    MessageBox.Show(@"Please fill in all the fields for right searching results");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;

                }
            }

            // this.Close();
        }

        private bool CheckPrice(string txtP)
        {
            try
            {
                this.Price = double.Parse(txtP);
                if (double.Parse(txtP) < 0)
                    return false;
                return true;

            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void Cncel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
