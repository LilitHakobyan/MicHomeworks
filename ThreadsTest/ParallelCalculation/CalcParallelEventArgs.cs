using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculation
{
    class CalcParallelEventArgs : EventArgs
    {
        public long Result { get; set; }
        public int TCount { get; set; }
        public long Time { get; set; }

    }
}