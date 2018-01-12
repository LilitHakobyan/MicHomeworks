using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class Saloon
    {   public int SaloonID { get; set; }
        public string Name { get; set; }
        public List<Car> cars;

        public Saloon(string name)
        {
            cars=new List<Car>();
            this.Name = name;
        }
    }
}
