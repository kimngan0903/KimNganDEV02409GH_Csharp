using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        private int[] MarkList = new int[3];
        public float StudAvgMark { get; private set; }

        // Index để truy cập và gán điểm cho mảng MarkList
        public int this[int index]
        {
            get => MarkList[index];
            set => MarkList[index] = value;
        }

        // Phương thức tính điểm trung bình
        public void CalAvg()
        {
            StudAvgMark = (MarkList[0] + MarkList[1] + MarkList[2]) / 3;
        }

        // Phương thức in thông tin
        public void Print()
        {
            Console.WriteLine($"ID: {StudID}, Name: {StudName}, Gender: {StudGender}, Age: {StudAge}, Class: {StudClass}, AvgMark: {StudAvgMark}");
        }
    }
}
