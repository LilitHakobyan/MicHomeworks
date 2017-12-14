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
    public partial class FormAddCar : Form
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ModelColor { get; set; }
        public double Price { get; private set; }
        public FormAddCar()
        {
            InitializeComponent();
        }
        public FormAddCar(string brandName,string modelName, string modelColor,double price)
        {
            InitializeComponent();
            this.txtBrand.Text = brandName;
            this.txtModelName.Text = modelName;
            this.txtModelColor.Text = modelColor;
            this.txtPrice.Text = price.ToString();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.BrandName = this.txtBrand.Text;
            this.ModelName = this.txtModelName.Text;
            this.ModelColor = this.txtModelColor.Text;
            this.Price = double.Parse(this.txtPrice.Text);
            // this.Close();
        }

        private void Cncel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
