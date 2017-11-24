using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class SwitcherUsingEv
    {
        public event SwitcherChangedEventHandler SwitcherChanged;

        public SwitcherUsingEv()
        {
            SwitcherChanged += OnSwitcherChanged;
        }

        protected virtual void OnSwitcherChanged(SwitcherStatus status)
        {
        }

        public void On()
        {
            SwitcherChanged(SwitcherStatus.On);
        }

        public void Off()
        {
            SwitcherChanged(SwitcherStatus.Off);
        }
        //public event SwitcherChangedEventHandler SwitcherChanged;

        //public void On()
        //{
        //    SwitcherChanged(SwitcherStatus.On);
        //}

        //public void Off()
        //{
        //    SwitcherChanged(SwitcherStatus.Off);
        //}
    }
}
