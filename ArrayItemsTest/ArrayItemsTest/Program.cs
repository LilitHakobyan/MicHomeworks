using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayItemsTest
{
    class Program
    {
        static bool IsEven(int item) { return item % 2 == 0; }
        static bool IsDivideByThree(int item) { return item % 3 == 0; }
        static bool IsContainsA(string item) { return item.Contains("a"); }

        static void Main(string[] args)
        {
            List<int> array = new List<int> { 3, 6, 9, 2, 4, 5, 3, 10, 16, 21, 2, 3 };

            array.GetElementsByCondition(IsDivideByThree)
                .MakeAction(Console.WriteLine);



















            string[] strs = new string[] { "hello", "Ararat", "John", "Varung" };

            ActionDelegate<int> del = Console.WriteLine;

            strs.GetElementsByCondition(IsContainsA)
                .MakeAction(Console.WriteLine);
        }
    }
}