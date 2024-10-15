namespace Lab02_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            int years, months, dayInMonths;

            // Nhập thông tin
            Console.Write("Nhập năm: ");
            years = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            months = int.Parse(Console.ReadLine());

            // Ngày trong tháng
            dayInMonths = DateTime.DaysInMonth(years, months);

            // In ra màn hình
            Console.WriteLine($"Tháng {months} năm {years} có {dayInMonths} ngày.");
        }
    }
}
