using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynemicTaypsTest
{
   public class Student
    {
        public string Name { get; set; }
        public  int Age { get; set; }
        public int StudentId { get; set; }

        public void ShowStInfo()
        {
            Console.WriteLine($"Student name is {Name}, Age {Age} and Id {StudentId}");
        }
    }
}
