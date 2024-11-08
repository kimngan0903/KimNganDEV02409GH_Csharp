namespace Lab08_1
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh họa cho việc sử dụng 1 số thao tác trên tệp dữ liệu sử dụng câu lệnh LINQ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo tập dữ liệu
            string[] data = { "To", "ve", "hon", "nguoi", "thi", "nguoi", "se", "tro", "thanh", "ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi", "thi", "nguoi", "se", "la", "ban", "cua", "ta" };

            // Truy vấn dữ liệu
            IEnumerable<string> result1 = from m in data select m;

            // Hiển thị kết quả
            Console.WriteLine("Hiển thị tất cả kết quả");
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }

            // Truy vấn theo điều kiện lấy các từ là "nguoi"
            IEnumerable<string> result2 = from m in data where m.Equals("nguoi")
            select m;

            // Hiển thị kết quả
            Console.WriteLine("\n Truy vấn theo điều kiện");
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }

            // Sắp xếp dữ liệu
            IEnumerable<string> result3 = from m in data orderby m select m;

            // Hiển thị kết quả
            Console.WriteLine("Hiển thị tất cả kết quả sắp xếp");
            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }

            // Lấy tập dữ liệu mới
            var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };

            // Hiển thị kết quả
            Console.WriteLine("Chữ thường và hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }
        }
    }
}
