using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Chef : Employee
    {
        Dictionary<string, int> meals;
        public Chef(string name, int experience) : base(name, experience)
        {
            meals = new Dictionary<string, int>();
        }
        public Chef(string name) : base(name)
        {
            meals = new Dictionary<string, int>();
        }
        public override void Work()
        {
            Experience++;
        }

        public void Cook(string mealname)
        {
            if (meals.ContainsKey(mealname))
            {
                meals[mealname]++;
            }
            else
            {
                meals.Add(mealname, 1);
            }
            Work();
            foreach(KeyValuePair<string, int> item in meals)
            {
                Console.WriteLine(item.Key + item.Value);
            }
            Console.WriteLine(Experience);
        }
    }
}
