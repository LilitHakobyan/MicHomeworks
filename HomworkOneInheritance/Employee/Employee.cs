using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee() {
            Console.WriteLine("Base class default  Constructor ");
        }

        public Employee(string name,int age):this(name, age, 0)
        {
            Console.WriteLine("Base Constructor with name and age");
        }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Console.WriteLine("Base Constructor with name and age and salary");

        }
    }
}
