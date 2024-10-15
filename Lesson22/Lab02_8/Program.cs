namespace Lab02_9
{
    internal class Program
    {
        /// <summary>
        /// Chương trinh nhập vào năm x tháng y sau đó in ra số ngày trong tháng ănm đó
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến
            int year, month, dayInMonth;

            // Nhập thông tin
            Console.Write("Nhập năm: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            month = int.Parse(Console.ReadLine());
            dayInMonth = DateTime.DaysInMonth(year, month); 

            //In kết quả
            Console.WriteLine($"Tháng {month} năm {year} có {dayInMonth} ngày.");
        }
    }
}
