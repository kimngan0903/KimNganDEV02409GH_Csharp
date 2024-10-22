namespace Lab06_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo và khởi tạo danh sách sinh viên sử dụng List generic
            List<Student> list = new List<Student>()
            {
                new Student { Id = "S10", FirstName = "Nguyễn Thu", LastName = "Phương", Avg = 9.5},
                new Student { Id = "S12", FirstName = "Trần Thị", LastName = "Thủy", Avg = 9.0 },
                new Student { Id = "S13", FirstName = "Lê Hoàng", LastName = "Nhật", Avg = 8.0 },
                new Student { Id = "S14", FirstName = "Nguyễn Văn", LastName = "Phong", Avg = 6.5 },
                new Student { Id = "S15", FirstName = "Hoàng Thị", LastName = "Huế", Avg = 9.7 },
                new Student { Id = "S16", FirstName = "Nguyễn Tiến", LastName = "Tùng", Avg = 5.0 },
                new Student { Id = "S17", FirstName = "Nguyễn Thiện", LastName = "Nhân", Avg = 4.8 }
            };

            // In danh sách sinh viên
            Console.Write("Danh sách sinh viên: ");
            foreach (var st in list)
            {
                Console.Write(st);
            }

            // Tìm sinh viên có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if (st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }

            // In kết quả
            Console.Write("Sinh viên có điểm cao nhất là: ");
            Console.Write(stmax);
        }
    }
}
