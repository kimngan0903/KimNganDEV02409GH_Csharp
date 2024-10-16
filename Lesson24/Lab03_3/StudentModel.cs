using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{
    internal class StudentModel
    {
        // Khai báo danh tập hợp chứa các sinh viên
        List<Student> liststudent;

        // Phương thức khởi tạo
        public StudentModel()
        {
            // Khởi tạo danh sách sinh viên
            this.liststudent = new List<Student>
            {
                new Student() { Id = 1, Name = "Con", Age = 21 },
                new Student() { Id = 2, Name = "Lợn", Age = 20 },
                new Student() { Id = 3, Name = "Nhựa", Age = 19 },
                new Student() { Id = 4, Name = "Má", Age = 18 },
                new Student() { Id = 5, Name = "Ơi", Age = 20 },
            };
        }
        #region các phương thức overloadiing
        // Phương thức trả về danh sách sinh viên
        public List<Student> GetStudent()
        {
            return liststudent;
        }

        // Phương thức trả về sinh viên theo id
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in liststudent)
            {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }

        // Phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudent) 
            { 
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}