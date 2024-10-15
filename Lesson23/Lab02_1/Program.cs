namespace Lab02_2
{
    internal class Program
    {
        /// <summary>
        /// Chương trình tính tiền điện
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến
            string name;
            int number;
            double money = 0;

            // Nhập thông tin
            Console.WriteLine("Nhập tên thuê bao: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập số điện sử dụng: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            // Tính toán số tiền
            if (number <= 30) 
                money = 30;
            else if (number > 30 && number <= 50) 
                money = 30 + (number - 30) * 1.2;
            else if (number > 50 )
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;

            // In thông tin
            Console.WriteLine("\n ---Thông tin tiền điện---");
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Số điện sử dụng: {0}", number);
            Console.WriteLine("Số tiền: {0:C}", money);
        }
    }
}
