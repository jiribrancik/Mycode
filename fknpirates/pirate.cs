using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fknpirates
{
    public class Pirate

    {
       

        public string Name { get; protected set; }
        public int GoldAmount { get; protected set; }
        public int HealthPoints { get; protected set; }
        public bool HasWoodenLeg { get; protected set; }
        public Pirate(string name)
        {
            Name = name;
            GoldAmount = 0;
            HealthPoints = 10;
            HasWoodenLeg = new Random().Next(4)==0;
        }
        public virtual void Work()
        {
            GoldAmount++;
            HealthPoints--;
        }
        public virtual void Party()
        {
            HealthPoints++;
        }
        public override string ToString()
        {
            if (HasWoodenLeg)
                return $"Hello, I'm {Name}. I have a wooden leg and {GoldAmount} golds.";

            return $"Hello, I'm {Name}. I have my real legs and {GoldAmount} golds.";
        }
    }
}
