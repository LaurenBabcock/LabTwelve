using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class RockyBalboa : Player
    {
        private Roshambo r = new Roshambo();

        public RockyBalboa()
        {
            name = "Rocky Balboa";
        }
      
        public override string GenerateRoshambo()
        {
            return r.GetRock();
        }
    }
}
