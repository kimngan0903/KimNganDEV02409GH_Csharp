using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3
{
    internal class Rectangle:Shape
    {
        // Phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhập chiều dài: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            width = int.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức tính diện tích
        public override float Area()
        {
            return length * width;
        }

        // Ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * length * width;
        }
    }
}
