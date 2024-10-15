namespace Lab02_5
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số nguyên tố từ 2 -100
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến đánh dấu
            bool check_i;
            Console.Write("Danh sách các số nguyên tố từ 2 - 100: ");

            // Duyệt từ 2 - 100
            for (int i = 2; i <= 100; i++)
            {
                check_i = true; // Giả sử y là số nguyên tố
                for (int j = 2; j <= i / 2; j++) // Duyệt từ 2-j/2
                { 
                    if (i % j == 0) // Nếu i chia hết cho j thì
                    {
                        check_i = false; // Kết luận là không có số nguyên tố
                        break;
                    }
                }
                if (check_i) // Nếu giả sử vẫn đúng -> i là số nguyên tố 
                {
                    Console.Write(" {0} ", i);
                }
            }
        }
    }
}
