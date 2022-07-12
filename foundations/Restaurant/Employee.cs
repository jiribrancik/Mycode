using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Employee
    {
        public int Experience { get; set; }
        public string Name { get; set; }
        public Employee(string name,int experience)
        {
            Experience = experience;
            Name = name;
        }
        public Employee(string name)
        {
            Experience = 1;
            Name = name;
        }
        public virtual void Work()
        {

        }
    }
}
