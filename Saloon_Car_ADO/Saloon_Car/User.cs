using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class User:EntityBase
    {
       public string Name { get; set; }
       public string Password { get; set; }
       public bool Role { get; set; }
      
    }
}
