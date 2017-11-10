using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class GasLamp : ILighter
    {
        public void Off()
        {
            Console.WriteLine("Gas Lamp Off");
        }

        public void On()
        {
            Console.WriteLine("Gas Lamp On");
        }
    }
}
