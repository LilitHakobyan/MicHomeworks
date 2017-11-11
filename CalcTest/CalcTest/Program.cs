using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string expression = Console.ReadLine();

                ExpressionCalculator calc = new ExpressionCalculator(expression);

                Console.WriteLine($"Result is {calc.Calculate()}\n");

            } while (true);
        }
    }
}