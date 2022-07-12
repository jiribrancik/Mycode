using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Waiter : Employee
    {
        public int Tips { get; set; }
        public Waiter(string name, int experience) : base(name, experience)
        {
            Tips = 0;
        }
        public Waiter(string name) : base(name)
        {
            Tips = 0;
        }
        public override void Work()
        {
            Tips++;
            Experience++;
        }
    }
}
