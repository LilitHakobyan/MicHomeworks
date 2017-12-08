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
            Dictionary<long,long > dictionaryResult=new Dictionary<long, long>();
            for (int i = 100; i < 500; i++)
            {
                ParallelCalc pCalc = new ParallelCalc((long)1E07, i);
                pCalc.Finished += ParallelCalc_Finished;
                pCalc.Start();
                dictionaryResult.Add(i,pCalc.time);
            }
            WriteInExcel.Log(dictionaryResult);
        }

    }
}
