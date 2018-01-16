using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
   public class Model:Entity
    {
        public Model(){}
        public string Name { get; set; }
        public string Color { get; set; }
        public Brand Brand { get; set; }
        public int BrandID { get; set; }
        public Model(Brand brand,string name,string color)
        {
            this.Brand = brand;
            this.Name = name;
            this.Color = color;
        }
    }
}
