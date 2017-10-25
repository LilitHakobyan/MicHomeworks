using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point m;
           // p.x = 10;
            int x = new int();
            Point p =new Point();
            Console.WriteLine(p);
            m.y = 15;
            Console.WriteLine(x);

            Point p1=new Point();
            Point p2= new Point();
            p1 = p2;
            p1.x = 10;
            Console.WriteLine(p2.x);
        }
    }
}
