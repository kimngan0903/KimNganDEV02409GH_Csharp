namespace Lab02_13
{
    internal class Program
    {
        /// <summary>
        /// Chương trình nhập vào 3 số nguyên
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            int a, b, c;

            // Nhập thông tin
            Console.Write("Nhập cạnh a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            c = int.Parse(Console.ReadLine());

            // Kiểm tra xem a, b, c có tạo thành tam giác không
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a, b, c tạo thành tam giác.");

                // Xác định loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không tạo thành tam giác.");
            }
        }
    }
}
