using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
// primer1
            //   string text = "tl";
            //   Thread tl = new Thread(() => Console.WriteLine(text) );
            //   text = "t2";
            //   Thread t2 = new Thread(() => Console.WriteLine(text));
            //   t2.Start(); tl.Start();

            //Thread.Sleep(11000);

            //Primer2


            Thread worker = new Thread(() => Console.ReadLine());
            //if (args.Length > 0)
                worker.IsBackground = true;
            worker.Start();
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
