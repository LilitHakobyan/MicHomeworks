using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandomNumber
{
    class Player
    {
        public int Point { get; private set; }
        public int Answer { get; private set; }
        public int IncScor()
        {
            return Point++;
        }

        
        public void GenAnswer()
        {
            try
            {
                int Answer = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Upsss   !!!!!!!!!!!!!!!!!!!!!!!!!!");
                GenAnswer();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
