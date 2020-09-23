using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Entities
{
    internal class TeamLead : Employee
    {
        List<Employee> employees = new List<Employee>();

        public TeamLead(string name, double salary) : base(name, salary)
        {

        }

        public override void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public override string GetData()
        {
            StringBuilder sbEmployee = new StringBuilder();

            foreach (Employee emp in employees)
            {
                sbEmployee.Append(emp.GetData() + "\n");
            }

            return sbEmployee.ToString();
        }

        public override void Remove(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
