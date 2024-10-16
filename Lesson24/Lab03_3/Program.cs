namespace Lab03_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đối tượng
            StudentModel action = new StudentModel();

            // Gọi phương thức lấy tất cả sinh viên
            List<Student> listall = action.GetStudent();

            // Hiển thị
            foreach (var item in listall)
            {
                item.Display();
            }

            // Gọi phương thức lấy sinh viên theo id
            Student st = action.GetStudent(2);

            // Hiển thị
            st.Display();

            // Gọi phương thức lấy sinh viên có tuổi từ 25 -30
            List<Student> listage = action.GetStudent(25, 30);

            // Hiển thị
            foreach (var item in listage)
            {
                item.Display();
            }
        }
    }
}
