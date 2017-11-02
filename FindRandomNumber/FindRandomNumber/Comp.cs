using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandomNumber
{
    public class Comp
    {
        public int Point { get; private set; }
        public int GenNumber { get; private set; } // gen number
        public void Generate()
        {
            Random rnum = new Random();
            GenNumber = rnum.Next(0, 9);
        }
        public bool Check(int answer)
        {
            if (GenNumber == answer)
            {
                return true;
            }
            return false;
        }
        public int IncScor()
        {
           return Point++;
        }
    }
}
