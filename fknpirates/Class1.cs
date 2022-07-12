using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fknpirates
{
    public class Captain : Pirate
    {
        public Captain(string name) : base(name)
        {
            
        }
        public override void Work()
        {
            GoldAmount += 10;
            HealthPoints -= 5;

        }
        public override void Party()
        {
            HealthPoints += 10;
        }

    }
}
