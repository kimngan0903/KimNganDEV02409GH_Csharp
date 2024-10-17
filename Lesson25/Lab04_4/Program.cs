namespace Lab04_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";

            // Gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);

            // Tạo sinh viên
            IPerson student = new Student() { Id = "S10", Name = "CHUNGLD", Age = 20 };

            // Hiển thị dữ liệu
            student.Display(student);
        }
    }
}
