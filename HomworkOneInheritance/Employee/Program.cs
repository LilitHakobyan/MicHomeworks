using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Meneger meneger=new Meneger("Hakob",33,33000.55,80);
            meneger.GetHashCode();
            SalesPerson salesP=new SalesPerson("David",30,5);
            salesP.GetHashCode();
            Console.ReadKey();
        }
    }
}
