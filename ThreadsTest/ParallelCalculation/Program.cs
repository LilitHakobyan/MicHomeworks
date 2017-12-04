using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculation
{
    class Program
    {
        private static void ParallelCalc_Finished(object sender, CalcParallelEventArgs e)
        {
            Console.WriteLine($"Threads count = {e.TCount}, SumOfNum={e.Result},Time={e.Time}");
        }
        static void Main(string[] args)
        {    
            ParallelCalc pCalc=new ParallelCalc((long)1E07, 500);
            pCalc.Finished += ParallelCalc_Finished;
            pCalc.Start();
        }

    }
}
