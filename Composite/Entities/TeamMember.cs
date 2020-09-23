using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Entities
{
    internal class TeamMember : Employee
    {
        public TeamMember(string name, double salary) : base(name, salary) 
        { 
        
        }

        public override void Add(Employee employee)
        {
            // Does nothing
        }

        public override string GetData()
        {
            return "Name: " + name + "\tSalary: " + salary.ToString("N2");
        }

        public override void Remove(Employee employee)
        {
            // Does nothing
        }
    }
}
