using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class Car
    {  
        public  Model Model { get; set;}
        public double Price { get; set; }
        public bool Sold { get; set; }
        public bool Deleted { get; set; }


        public Car(Model model,double price)
        {
            this.Model = model;
            this.Price = price;
            this.Sold = false;
            this.Deleted = false;
        }
    }
}
