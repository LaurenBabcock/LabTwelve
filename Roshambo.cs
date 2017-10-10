using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class Roshambo
    {
        private Random rnd = new Random();

        public string GetRock()
        {
            return "Rock";
        }

        public string GetPaper()
        {
            return "Paper";
        }

        public string GetScissors()
        {
            return "Scissors";
        }

        public string GetRandom()
        {        
            int randomNumber = rnd.Next(1, 4);
           
            switch (randomNumber)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return "invalid";
            }
        }
    }
}
