using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsAndCustomers
{
    class Program
    {
        private static Queue<int> Product;
        private static readonly object LockObj;
        static Random r = new Random();
        static void Producere()
        {
            lock (LockObj)
            {
                while (true)
                {
                    Thread.Sleep(r.Next(0, 100));
                    Product.Enqueue(5);

                    if (Product.Count == 20)
                        Monitor.PulseAll(LockObj);
                }
            }
        }

        static void Costomer()
        {

            while (true)
            {
                lock (LockObj)
                {
                    if (!Product.Any())
                    {
                        Monitor.Wait(LockObj);
                    }
                    else
                    {
                        Thread.Sleep(r.Next(0, 100));
                        Product.Dequeue();
                    }
                    if(Product.Count==20)
                        Monitor.PulseAll(LockObj);

                }

            }

        }

        static void Main(string[] args)
        {
        }
    }
}
