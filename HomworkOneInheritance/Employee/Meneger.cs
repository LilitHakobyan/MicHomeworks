using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Meneger:Employee
    {
        public int IdCard { get; set; }

        public Meneger()
        {
            Console.WriteLine("Class Meneger default constructor");
        }

        public Meneger(string name,int age, double salery, int id):base(name, age,salery)
        {
            IdCard = id;
            Console.WriteLine("Constructor of Meneger"); 

        }

    }
}
