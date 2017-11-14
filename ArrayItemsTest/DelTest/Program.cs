using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelTest
{
    class Program
    {
        static double Squr(int x) => x * x;
        static void Main(string[] args)
        {
            int[] arr = {2, 5, 5, 8, 9, 2, 7, 9, 3, 7};
            arr.AnyAction(Squr).Display(Console.WriteLine);
        }
    }
}

