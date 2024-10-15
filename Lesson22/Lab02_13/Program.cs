namespace Lab02_14
{
    internal class Program
    {
        /// <summary>
        /// Chương trình hiển thị ra hình 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int rows = 10; // Số hàng trong tam giác
            for (int i = 1; i <= rows; i++)
            {
                // In khoảng trắng trước mỗi hàng
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                // In các số tăng dần
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                // In các số giảm dần
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                // Xuống dòng
                Console.WriteLine();
            }
        }
    }
}
