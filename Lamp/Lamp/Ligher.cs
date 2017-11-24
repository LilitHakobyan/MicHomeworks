using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class Ligher
    {
        SwitcherUsingEv switcher;

        public Ligher(SwitcherUsingEv switcher)
        {
            this.switcher = switcher;
            this.switcher.SwitcherChanged += Switcher_SwitcherChanged;
        }

        private void Switcher_SwitcherChanged(SwitcherStatus status)
        {
            switch (status)
            {
                case SwitcherStatus.On:
                    this.On();
                    break;
                case SwitcherStatus.Off:
                    this.Off();
                    break;
                default:
                    break;
            }
        }

        private void On()
        {
            Console.WriteLine("On");
        }
        private void Off()
        {
            Console.WriteLine("Off");
        }
    }
}
