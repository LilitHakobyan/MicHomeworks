using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandomNumber
{
    class Player
    {
        private int point;

        public int Point
        {
            get { return point; }
            set
            {
                if (value >= 0)
                    point = value;
                else
                {
                    Console.WriteLine("Player point must be > or = 0");
                }
            }
        }


    }
}
