using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class RandoMcDando : Player
    {
        private Roshambo r = new Roshambo();

        public RandoMcDando()
        {
            name = "Rando McDando";
        }

        public override string GenerateRoshambo()
        {            
            return r.GetRandom();
        }
    }
}
