using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_6
{
    internal class Car
    {
        // Khai báo các thuộc tính tự động
        public string Name { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        // Ghi đè phương thức tostring
        public override string ToString()
        {
            return "\nName: " + Name + "\nColor: " + Color;
        }
    }
}
