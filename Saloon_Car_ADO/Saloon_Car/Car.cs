using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class Car:EntityBase
    {   public  Model Model { get; set;}
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool Deleted { get; set; }
        public int SalonID { get; set; }
        public int ModelID { get; set; }

        public Car(Model model,decimal price)
        {
            this.Model = model;
            this.Price = price;
           
        }
    }
}
