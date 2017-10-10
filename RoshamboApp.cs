using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class RoshamboApp
    {

        private int playerWins = 0;
        private int opponentWins = 0;
        private int draws = 0;
        
        public Player SelectOpponent()
        {

            string userSelection;
            Console.WriteLine("Do you want to play against Rocky Balboa or Rando McDando?");
            Console.Write("Type Rocky or Rando to decide: ");
            userSelection = Console.ReadLine().ToUpper();

            switch (userSelection)
            {
                case "ROCKY":
                    RockyBalboa rocky = new RockyBalboa();
                    return rocky;
                case "RANDO":
                    RandoMcDando rando = new RandoMcDando();
                    return rando;
                default:
                    Console.WriteLine("Sorry, you must pick Rocky or Rando.");
                    return SelectOpponent();
            }

        }

        public void RunTurn(Player user, Player opponent)
        {
            string userPick;
            string opponentPick;

            userPick = user.GenerateRoshambo();
            opponentPick = opponent.GenerateRoshambo();

            Console.WriteLine($"{user.GetName()} picked {userPick}.");
            Console.WriteLine($"{opponent.GetName()} picked {opponentPick}.");

            string turnResult = GetResult(userPick, opponentPick);

            if (turnResult == "WIN")
            {
                playerWins++;
                Console.WriteLine($"{user.GetName()} wins!");
            }
            else if (turnResult == "LOSE")
            {
                opponentWins++;
                Console.WriteLine($"{opponent.GetName()} wins!");
            }
            else
            {
                draws++;
                Console.WriteLine("Draw!");
            }

        }

        public string GetResult(string uPick, string oPick)
        {
            if (uPick == oPick)
            {               
                return "DRAW";
            }
            else if ((uPick == "Rock" && oPick == "Scissors") || (uPick == "Paper" && oPick == "Rock") || (uPick == "Scissors" && oPick == "Paper"))
            {
                return "WIN";
            }
            else
            {
                return "LOSE";
            }          
        }

        public void GetScore()
        {
            Console.WriteLine($"You won {playerWins} games and your opponent won {opponentWins} games. There were {draws} games that ended in a draw.");
        }

    }
}
