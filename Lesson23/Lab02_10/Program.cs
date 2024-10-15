namespace Lab02_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            int sum;

            // Nhập thông tin và in ra màn hình
            Console.WriteLine("Các số có tổng 3 chữ số là chẵn từ 100 đến 999:");
            for (int i = 100; i <= 999; i++)
            {
                sum = (i / 100) + ((i / 10) % 10) + (i % 10);
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
