namespace Lab01_1
{
    internal class Program
    {
        /// <summary>
        /// Chương trình C# đầu tiên
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lệnh in ra màn hình 1 dòng văn bản, sau đó xuống dòng
            Console.WriteLine("Họ và tên: Phạm Thị Kim Ngân");
            Console.WriteLine("Ngày sinh: 09/03/2003");
            Console.WriteLine("Địa chỉ: Hỉa Phòng");
            Console.WriteLine("Điện thoại: 0373993662");
            Console.WriteLine("Rấ vui khi được học Csharp");

            // Lệnh dừng màn hình và chờ nhấn 1 phím
            Console.Read();
        }
    }
}
