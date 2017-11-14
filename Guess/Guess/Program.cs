using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Быкиикоровы;

namespace Guess
{
    class Program
    {
        static bool  Game_F(int compNumber)
        {
            int userNumber = 0;
            bool result = false;
            int[] usNum = new int[3];
            int [] compNum =new int[3];
            for (int i = 0; i < compNum.Length; i++)
            {
                compNum[compNum.Length - i - 1] = compNumber % 10;
                compNumber = compNumber / 10;
            }
            while (!result)
            {
                do
                {
                    Console.WriteLine("Please write 3 numbers ");
                   // userNumber = Convert.ToInt32(Console.ReadLine());
                    bool res = Int32.TryParse(Console.ReadLine(), out userNumber);
                    if (!res)
                    {
                        Console.WriteLine("Wrong input");
                    }
                   

                } while (userNumber < 100 || userNumber > 999);

                for (int i = 0; i < usNum.Length; i++)
                {
                    usNum[usNum.Length - i - 1] = userNumber % 10;
                    userNumber = userNumber / 10;
                }
                int bk = 0;
                int kr = 0;
                for (int i = 0; i < compNum.Length; i++)
                {
                    for (int j = 0; j < usNum.Length; j++)
                    {
                        if (compNum[i]==usNum[j])
                        {
                            if (i==j)
                            {
                                kr++;
                            }
                            else
                            {
                                bk++;
                            }
                        }
                    }
                }
                Console.WriteLine($"Быки= {bk}  , Коровы= {kr}");
                if (kr==3)
                {
                    result = true;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Player comp=new Player();
            Player user=new Player();
            Console.WriteLine("~~~~Let's play");

            Random rnum = new Random();
            int numberRandom = rnum.Next(100, 999);
            bool result=Game_F(numberRandom);
            Console.WriteLine("Cong");
        }
    }
}
