using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
   public class Brand
    {   public int BrandID { get; set; }
        public string Name { get; set; }
        public List<Model> models;//=new List<Model>();

        public Brand(){}
        public Brand(string name)
        {
            this.Name = name;
            models = new List<Model>();
        }

        
    }
}
