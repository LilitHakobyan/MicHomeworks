using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
    class User
    {
       public  int UserID { get; set; }
       public string Name { get; set; }
       public string Password { get; set; }
       public UserEnum Role { get; set; }
      
    }
}
