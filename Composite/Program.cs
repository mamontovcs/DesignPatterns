using Composite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeA = new TeamMember("Vitaliy", 25000);

            var employeeB = new TeamMember("Sasha", 25000);

            Employee teamLead = new TeamLead("Misha", 100000);

            teamLead.Add(employeeA);

            teamLead.Add(employeeB);

            Console.WriteLine(teamLead.GetData());

            Console.Read();
        }
    }
}
