using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Player compPlayer=new Player();
            Player userPlayer=new Player();
            Console.WriteLine("~~~~~Let start the game~~~~");

            while (compPlayer.Point!=5 && userPlayer.Point!=5)
            {
                Random rnum = new Random();
                int numberRandom = rnum.Next(0, 9);
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please write number ");
                    try
                    {
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (number == numberRandom)
                        {
                            userPlayer.Point += 1;
                            Console.WriteLine($"User {userPlayer.Point} : Comp {compPlayer.Point} :");
                            break;
                        }
                        else
                        {

                            if (i == 4)
                            {
                                compPlayer.Point += 1;
                                Console.WriteLine($"Random number is {numberRandom}");
                                Console.WriteLine($"User {userPlayer.Point} : Comp {compPlayer.Point} :");
                            }
                            else
                            {
                                Console.WriteLine("Wrong, try again!!!!!!!!!!!!");
                            }
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Upsss   !!!!!!!!!!!!!!!!!!!!!!!!!!");
                        i--;
                    }
                    

                }

            }
            if (userPlayer.Point==5)
            {
                Console.WriteLine("Congratulations you win the game");
            }
            else
            {
               
                Console.WriteLine("Sorry you lost the game, don't worry try again ");
            }
            Console.ReadKey();


        }
    }
}
