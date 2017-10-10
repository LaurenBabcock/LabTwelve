using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    abstract class Player
    {
        protected string name;

        public abstract string GenerateRoshambo();

        public string GetName()
        {
            return name;
        }

    }
}
