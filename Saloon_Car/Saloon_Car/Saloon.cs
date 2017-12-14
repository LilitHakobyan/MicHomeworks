using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class Saloon
    {
        public string Name { get; set; }
        public List<Car> cars;

        public Saloon(string name)
        {
            cars=new List<Car>();
            this.Name = name;
        }
    }
}
