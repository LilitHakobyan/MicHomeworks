using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Saloon_Car
{
    public partial class Form1 : Form
    {
        private int i = 0;
        List<DataViewModel> dataViewModels = new List<DataViewModel>();

        Saloon saloon = new Saloon("Avto.am");
        List<Brand> brendList = new List<Brand>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            dataViewModels = JsonConvert.DeserializeObject<List<DataViewModel>>(File.ReadAllText(@"E:\salon.log"));
            dataGridView1.DataSource = dataViewModels;
            foreach (DataViewModel viewModel in dataViewModels)
            {
                CreateNewItem(viewModel.Brand, viewModel.Model, viewModel.Color, viewModel.Price);

            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
           
            FormAddCar formAdd = new FormAddCar();
            formAdd.ShowDialog();
            if (formAdd.DialogResult == DialogResult.OK)
            {
                CreateNewItem(formAdd.BrandName, formAdd.ModelName, formAdd.ModelColor, formAdd.Price);
                dataViewModels.Add(new DataViewModel { Id = ++i, Brand = formAdd.BrandName, Model = formAdd.ModelName, Color = formAdd.ModelColor, Price = formAdd.Price,Sold = false});
                RerefreshGridAndData();
            }

        }

        private void CreateNewItem(string brandName,string modelName, string modelColor,double price)
        {
            Brand brand = new Brand();
            foreach (Brand item in brendList)
            {
                if (item.Name == brandName)
                    brand = item;
            }
            if (string.IsNullOrEmpty(brand.Name))
            {
                brand = new Brand(brandName);
                brendList.Add(brand);
            }

            Model model = new Model()
            {
                Name = modelName,
                Color = modelColor,
                Brand = brand
            };
            brand.models.Add(model);
            Car car = new Car(model, price);
            saloon.cars.Add(car);
            //dataViewModels.Add(new DataViewModel { Id = i++, Brand = brand.Name, Model = model.Name, Color = model.Color, Price = car.Price });

        }
        private void Edit_Click(object sender, EventArgs e)
        {
            DataViewModel viewModels = (DataViewModel)dataGridView1.SelectedRows[0]?.DataBoundItem;
            //viewModels[0].Price = 0;
            DataViewModel carItem= dataViewModels.FirstOrDefault(x => x.Id == viewModels.Id);
            FormAddCar formAdd = new FormAddCar(carItem.Brand, carItem.Model, carItem.Color, carItem.Price);
            formAdd.ShowDialog();
            if (formAdd.DialogResult == DialogResult.OK)
            {
              var FindCar=  saloon.cars.FirstOrDefault(item =>
                    item.Model.Brand.Name == carItem.Brand &&
                    item.Model.Name == carItem.Model &&
                    item.Model.Color == carItem.Color &&
                    item.Price == carItem.Price

                );
                if (FindCar == null)
                {
                    MessageBox.Show("Car not found");
                    
                }
                else
                {
                    carItem.Brand = formAdd.BrandName;
                    carItem.Model = formAdd.ModelName;
                    carItem.Color = formAdd.ModelColor;
                    carItem.Price = formAdd.Price;

                    FindCar.Model.Brand.Name = formAdd.BrandName;
                    FindCar.Model.Name = formAdd.ModelName;
                    FindCar.Model.Color = formAdd.ModelColor;
                    FindCar.Price = carItem.Price;
                    RerefreshGridAndData();
                }
               

               
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataViewModel viewModels = (DataViewModel)dataGridView1.SelectedRows[0]?.DataBoundItem;
            //viewModels[0].Price = 0;
            DataViewModel carItem = dataViewModels.FirstOrDefault(x => x.Id == viewModels.Id);
            carItem.Deleted = true;

            var FindCar = saloon.cars.FirstOrDefault(item =>
                item.Model.Brand.Name == carItem.Brand &&
                item.Model.Name == carItem.Model &&
                item.Model.Color == carItem.Color &&
                item.Price == carItem.Price

            );
            if (FindCar == null)
            {
                MessageBox.Show("Car not found");
            }
            else
            {
                FindCar.Deleted = true;
                RerefreshGridAndData();
            }
          


        }

        public void RerefreshGridAndData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataViewModels;
            string serializeString = JsonConvert.SerializeObject(dataViewModels, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            File.WriteAllText(@"E:\salon.log", serializeString);
        }
    }
}
