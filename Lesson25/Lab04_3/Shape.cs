using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3
{
    // Định nghĩa lớp trừu tượng
    abstract class Shape
    {
        protected float radius, length, width;

        // Khai báo các phương thức trừu tượng
        public abstract float Area(); // Tính diện tích
        public abstract float Circumference(); // Tính chu vi
    }
}
