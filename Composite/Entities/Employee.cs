using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Entities
{
    internal abstract class Employee
    {
        protected string name;

        protected double salary;

        protected Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public abstract void Add(Employee employee);

        public abstract void Remove(Employee employee);

        public abstract string GetData();
    }
}
