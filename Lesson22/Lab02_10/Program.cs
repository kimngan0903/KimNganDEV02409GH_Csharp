namespace Lab02_11
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số tổng 3 chưc số là chẵn từ 100-999
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Các số có tổng 3 chữ số là chẵn từ 100 đến 999:");
            for (int i = 100; i <= 999; i++)
            {
                int sum = (i / 100) + ((i / 10) % 10) + (i % 10);
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
