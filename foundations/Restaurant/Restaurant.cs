using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Restaurant
    {
        public string Name { get; set; }
        public int YearFounded { get; set; }
        List<Employee> Employees;
        public Restaurant(string name, int yearFounded)
        {
            Name = name;
            YearFounded = yearFounded;
            Employees = new List<Employee>();
        }
        public void GuestsArrived()
        {
            foreach(Employee employee in Employees)
            {
                employee.Work();
                Console.WriteLine(employee.Name);
            }
        }
        public void Hire(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
