using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4
{
    // Định nghõa lớp sinh viên thực thi từ giao diện IPerson
    internal class Student:IPerson
    {
        // Khai báo thuộc tính
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Thực thi các phương thức từ giao diện
        public void Insert(Object obj)
        {
            Console.WriteLine("Đã lưu đối tượng: " + obj);
        }

        public void Delete(Object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }

        public void Update(Object obj)
        {
            Console.WriteLine("Đã cập nhật đối tượng: " + obj);
        }

        public void Display(Object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id: " + st.Id);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Age: " + st.Age);
        }
    }
}
