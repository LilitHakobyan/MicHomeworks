using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4, 5, 3, 9, 4, 12, 78, 3, 57, 1};
            DynamicArray array=new DynamicArray(arr);
            Console.WriteLine(array.Find(3));
            array.Add(15);
            array.ShowOnConsole();
            Console.WriteLine(array.Contains(0));
            array.Remove(12);
            array.ShowOnConsole();
            Console.ReadKey();
        }
    }
}
