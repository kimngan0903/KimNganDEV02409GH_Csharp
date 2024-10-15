namespace Lab02_12
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các hình
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Hình a
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            // Hình b
            // Mảng lưu trữ số lượng ký tự 'S' trên mỗi dòng
            int[] lines = { 6, 5, 4, 3, 2, 1 };

            // Lặp qua từng giá trị trong mảng để in ký tự 'S'
            foreach (int count in lines)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("S");
                }
                Console.WriteLine(); // Xuống dòng sau khi in xong một hàng
            }

            // Hình c
            for (int i = 1, k = 0; i <= 6; ++i, k = 0)
            {
                for (int space = 1; space <= 6 - i; ++space)
                {
                    Console.Write("  ");
                }

                while (k != 2 * i - 1)
                {
                    Console.Write("* ");
                    ++k;
                }

                Console.WriteLine();
            }
        }
    }
}
