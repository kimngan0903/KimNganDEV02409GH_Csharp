using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_8
{
    internal class Lecture
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public Lecture() { }
        public void Display()
        {
            Console.WriteLine("========Lương của giảng viên========");
            Console.WriteLine("Name: " + Name + "Salary: " + Salary + "Bonus: " + Bonus);
        }
    }
}
