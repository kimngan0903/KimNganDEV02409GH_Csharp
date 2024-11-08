using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_8
{
    internal class Department
    {
        public string Name { get; set; }
        private Employee[] employees;

        public Department(string name, int size)
        {
            this.Name = name;
            this.employees = new Employee[size];
        }

        public Employee this[int index]
        {
            get { return employees[index]; }
            set { employees[index] = value; }
        }
    }
}
