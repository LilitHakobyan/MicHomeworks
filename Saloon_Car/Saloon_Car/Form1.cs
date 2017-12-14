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
        private List<DataViewModel> dataViewModels;
        private int i;

        Saloon saloon = new Saloon("Avto.am");
        List<Brand> brendList = new List<Brand>();
        public Form1()
        {
            InitializeComponent();
            Initializer();
        }

        public void Initializer()
        {
            try
            {
                dataGridView1.MultiSelect = false;
                dataViewModels = JsonConvert.DeserializeObject<List<DataViewModel>>(File.ReadAllText(@"E:\salon.log"));
                dataGridView1.DataSource = dataViewModels;
                i = dataViewModels.Last().Id;
                foreach (DataViewModel viewModel in dataViewModels)
                {
                    CreateNewItem(viewModel.Brand, viewModel.Model, viewModel.Color, viewModel.Price);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {

            FormAddChangeCar formAdd = new FormAddChangeCar();
            formAdd.ShowDialog();
            if (formAdd.DialogResult == DialogResult.OK)
            {
                CreateNewItem(formAdd.BrandName, formAdd.ModelName, formAdd.ModelColor, formAdd.Price);
                dataViewModels.Add(new DataViewModel { Id = ++i, Brand = formAdd.BrandName, Model = formAdd.ModelName, Color = formAdd.ModelColor, Price = formAdd.Price, Sold = false });//
                RerefreshGridAndData();
            }

        }

        private void CreateNewItem(string brandName, string modelName, string modelColor, double price)
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
            try
            {
                DataViewModel viewModels = (DataViewModel)dataGridView1.SelectedRows[0]?.DataBoundItem;
                //viewModels[0].Price = 0;
                DataViewModel carItem = dataViewModels.FirstOrDefault(x => x.Id == viewModels.Id);
                FormAddChangeCar formAdd =
                    new FormAddChangeCar(carItem.Brand, carItem.Model, carItem.Color, carItem.Price);
                formAdd.ShowDialog();
                if (formAdd.DialogResult == DialogResult.OK)
                {
                    Car findCar = FindCarItem(carItem.Brand, carItem.Model, carItem.Color, carItem.Price);

                    if (findCar == null)
                    {
                        MessageBox.Show("Car not found");
                    }
                    else
                    {
                        carItem.Brand = formAdd.BrandName;
                        carItem.Model = formAdd.ModelName;
                        carItem.Color = formAdd.ModelColor;
                        carItem.Price = formAdd.Price;

                        findCar.Model.Brand.Name = formAdd.BrandName;
                        findCar.Model.Name = formAdd.ModelName;
                        findCar.Model.Color = formAdd.ModelColor;
                        findCar.Price = carItem.Price;
                        RerefreshGridAndData();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Choose a line");
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataViewModel viewModels = (DataViewModel)dataGridView1.SelectedRows[0]?.DataBoundItem;
            //viewModels[0].Price = 0;
            DataViewModel carItem = dataViewModels.FirstOrDefault(x => x.Id == viewModels.Id);
            carItem.Deleted = true;

            Car findCar = FindCarItem(carItem.Brand, carItem.Model, carItem.Color, carItem.Price);

            if (findCar == null)
            {
                MessageBox.Show("Car not found");
            }
            else
            {
                findCar.Deleted = true;
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            FormAddChangeCar formAdd = new FormAddChangeCar(true);
            formAdd.ShowDialog();
            Car findCar = FindCarItem(formAdd.BrandName, formAdd.ModelName, formAdd.ModelColor);
            if (findCar == null)
            {
                MessageBox.Show(@"Car not found");
            }
            else
            {
                var rowId = dataViewModels.FirstOrDefault(item =>
                    item.Brand == findCar.Model.Brand.Name && item.Model == findCar.Model.Name &&
                    item.Color == findCar.Model.Color).Id;
                dataGridView1.Rows[rowId - 1].Selected = true;

            }

        }

        private Car FindCarItem(string brandName, string modelName, string modelColor,
            double price = 0.0)
        {
            if (price == 0.0)
            {
                Car resultCar = saloon.cars.FirstOrDefault(item =>
                    item.Model.Brand.Name.ToLower() == brandName.ToLower() &&
                    item.Model.Name.ToLower() == modelName.ToLower() &&
                    item.Model.Color.ToLower() == modelColor.ToLower()
                );
                return resultCar;
            }
            else
            {
                Car resultCar = saloon.cars.FirstOrDefault(item =>
                    item.Model.Brand.Name == brandName &&
                    item.Model.Name == modelName &&
                    item.Model.Color == modelColor &&
                    item.Price == price
                );
                return resultCar;
            }


        }
    }
}
