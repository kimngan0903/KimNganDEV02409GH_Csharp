using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_5
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }


        public double getInCome()
        {
            double InCome = (salaryLevel * basicSalary);
            return InCome;
        }

        public void Display()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year of Birth: " + yearOfBirth);
            Console.WriteLine("Basic Salary: " + basicSalary);
        }
    }
}
