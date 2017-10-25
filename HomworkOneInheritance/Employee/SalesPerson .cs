using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class SalesPerson:Employee
    {
        public int StockOptions { get; set; }

        public SalesPerson()
        {
            Console.WriteLine("Default constructor of SalesPerson class");
        }

        public SalesPerson(string name, int age, int stockOp) : base(name, age)
        {
            StockOptions = stockOp;
            Console.WriteLine("Constructor of SalesPerson");
        }

    }
}
