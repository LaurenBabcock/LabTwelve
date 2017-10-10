using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int numberOfRounds = 0;
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            RoshamboApp newGame = new RoshamboApp();
            UserPlayer user = new UserPlayer();
            Console.WriteLine();
            Player opponent = newGame.SelectOpponent();
            Console.WriteLine();

            while (run == true)
            {

                newGame.RunTurn(user, opponent);
                numberOfRounds++;

                Console.WriteLine();
                run = Continue();
                Console.WriteLine();
            }

            Console.WriteLine($"You played {numberOfRounds} rounds.");
            newGame.GetScore();
        }

        static bool Continue()
        {
            Console.Write("Would you like to play again (Y/N)? ");
            string input = Console.ReadLine().ToUpper();
            bool doAgain;
            if (input == "Y")
            {
                doAgain = true;
            }
            else if (input == "N")
            {
                doAgain = false;
            }
            else
            {
                Console.WriteLine("That is not a valid response. Please try again.");
                doAgain = Continue();
            }

            return doAgain;
        }
    }
}
