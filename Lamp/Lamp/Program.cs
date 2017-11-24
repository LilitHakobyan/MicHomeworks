using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switcher sw = new Switcher(new GasLamp());

            //sw.SwitchOn();
            //sw.SwitchOff();
            SwitcherUsingEv switcher=new SwitcherUsingEv();
            Ligher l= new Ligher(switcher);
            switcher.Off();
        }
    }
}

