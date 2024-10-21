using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_3
{
    /// <summary>
    /// Lớp sinh viên
    /// </summary>
    /// <param name="args"></param>
    internal class Student
    {
        // Khai báo mảng tên
        string[] names;

        // Khai báo mảng 2 chiều điểm
        double[,] marks;

        // Phương thức khởi tạo
        public Student(int n, int m)
        {
            names = new string[n];
            marks = new double[n, m];
        }

        // Chỉ mục đơn 
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }

        // Chỉ mục kép
        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
