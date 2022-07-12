using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Manager : Employee
    {
        public int MoodLevel { get; set; }
        public Manager(string name, int experience) : base(name, experience)
        {
            MoodLevel = 400;
        }
        public Manager(string name) : base(name)
        {
            MoodLevel = 400;
        }
        
        public void Meeting()
        {
            MoodLevel -= Experience;
        }
        public override void Work()
        {
            Experience++;
            Meeting();
        }

    }
}
