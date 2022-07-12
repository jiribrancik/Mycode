using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fknpirates
{
    public class Ship
    {
        List<Pirate> Pirates;
        public bool HasCaptain;

        public Ship()
        {
            Pirates = new List<Pirate>();
        }
        public void Add(Pirate p)
        {
            if (p is Captain)
            {
                if (HasCaptain)
                    return;
                else
                {
                    Pirates.Add(p);
                    HasCaptain = true;
                }
            }

            Pirates.Add(p);
        }
        public int Count()
        {
            return Pirates.Count;
        }
        public List<string> PoorPirates()
        {
            List<string> vs = new List<string>();
            foreach (Pirate p in Pirates)
                if (p.GoldAmount < 15 && p.HasWoodenLeg)
                    vs.Add(p.Name);
            return vs;
        }
        public int GetGold()
        {
            int sumgold = 0;
            foreach (Pirate p in Pirates)
                sumgold += p.GoldAmount;
            return sumgold;

        }
        public void LastDayOnTheShip()
        {
            foreach (Pirate p in Pirates)
                p.Party();

        }
        public void PrepareForBattle()
        {
            foreach (Pirate p in Pirates)
            {
                for (int i = 0; i < 5; i++)
                    p.Work();
            }
            LastDayOnTheShip();
        }

    }

}

