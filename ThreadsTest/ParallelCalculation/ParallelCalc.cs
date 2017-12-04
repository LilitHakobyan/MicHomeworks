using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelCalculation
{
    class ParallelCalc
    {
        public long[] results;
        public Thread[] threads;


        public long MaxNum { get; set; }
        public int ThCount { get; set; }
        public event CalcFinishedEventHandler Finished;
        public ParallelCalc(long maxNum, int thCount)
        {
            MaxNum = maxNum;
            ThCount = thCount;
        }

        private void Sum(long start, long end, ref long res)
        {
            for (long i = start; i < end; i++)
            {
                res += i;
            }
            
        }
        public void Start()
        {
           
            results=new long[ThCount];
            threads=new Thread[ThCount];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <ThCount; i++)
            {

                 int j = i;
                threads[i]=new Thread(()=>Sum((MaxNum/ThCount)*j, (MaxNum / ThCount) * (j+1),ref results[j]));

                threads[i].Start();
            }

            while (threads.Any(t => t.IsAlive));
            sw.Stop();
            Finished?.Invoke(this,new CalcParallelEventArgs(){Result = results.Sum(),TCount =ThCount,Time =sw.ElapsedMilliseconds });


        }

        

       
    }


}


