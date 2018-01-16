using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon_Car
{
  public  class EntityBase
    {
        [Browsable(false)]
        public int Id { get; set; } = -1;
    }
}
