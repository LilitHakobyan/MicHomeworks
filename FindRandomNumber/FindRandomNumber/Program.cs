using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandomNumber
{
    class Program
    {
        static void Game_F(Comp compPlayer, Player userPlayer)
        {
            compPlayer.Generate();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please write number ");
                userPlayer.GenAnswer();

                if (compPlayer.Check(userPlayer.Answer))
                {
                    userPlayer.IncScor();
                    Console.WriteLine($"User {userPlayer.Point} : Comp {compPlayer.Point} :");
                    break;
                }

                if (i == 4)
                {
                    compPlayer.IncScor();
                    Console.WriteLine($"Random number is {compPlayer.GenNumber}");
                    Console.WriteLine($"User {userPlayer.Point} : Comp {compPlayer.Point} :");
                }
                else
                {
                    Console.WriteLine("Wrong, try again!!!!!!!!!!!!");
                }

            }



        }

        static void Main(string[] args)
        {
            Comp compPlayer = new Comp();
            Player userPlayer = new Player();
            Console.WriteLine("~~~~~Let start the game~~~~");
            while (compPlayer.Point != 5 && userPlayer.Point != 5)
            {
                Game_F(compPlayer, userPlayer);
            }
            if (userPlayer.Point == 5)
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
