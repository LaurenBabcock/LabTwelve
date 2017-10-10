using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class UserPlayer : Player
    {
        private Roshambo r = new Roshambo();

        public UserPlayer()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }

        public override string GenerateRoshambo()
        {
            string userSelection;
            Console.Write("Please enter Rock, paper, or scissors: ");
            userSelection = Console.ReadLine().ToUpper();

            switch (userSelection)
            {
                case "ROCK":
                    return r.GetRock();
                case "PAPER":
                    return r.GetPaper();
                case "SCISSORS":
                    return r.GetScissors();
                default:
                    Console.WriteLine("That is not valid. Please try again.");
                    return GenerateRoshambo();
            }
        }
    }
}
