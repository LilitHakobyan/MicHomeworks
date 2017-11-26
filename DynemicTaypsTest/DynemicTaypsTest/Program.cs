using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynemicTaypsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic dynamicStudent = new Student();

            //dynamicStudent.ShowStInfo();

            dynamic list = new List<int>();
            dynamic result = list.Add(5); // 
            Console.WriteLine(result);
        }
    }
} 
