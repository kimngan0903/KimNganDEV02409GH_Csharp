using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3
{
    internal class Circle:Shape
    {
        // Phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhập bán kính: ");
            radius = int.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }

        // Ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
