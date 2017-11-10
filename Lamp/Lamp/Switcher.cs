using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class Switcher
    {
        public ILighter lighter;

        public Switcher(ILighter d)
        {
            this.lighter = d;
        }

        public void SwitchOn()
        {
            lighter.On();
        }

        public void SwitchOff()
        {
            lighter.Off();
        }
    }
}
