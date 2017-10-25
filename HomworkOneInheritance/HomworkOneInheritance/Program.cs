using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomworkOneInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Rectangular rect= new Rectangular(4,6);
        //    rect.Drow();
        //    Console.WriteLine("----------------------------------");
            Triangular triangular = new Triangular(4,7);
            triangular.Drow();
            Console.WriteLine("----------------------------------");

            //Quadrate quadrate =new Quadrate(6);
            //quadrate.Drow();
            //Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }
    }
}
