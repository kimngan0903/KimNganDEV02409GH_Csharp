namespace Lab02_10
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra định dạng hh:mm:ss
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            int hours, minutes, seconds, totalSeconds;

            // Nhập thông tin
            Console.Write("Nhập số giây: ");
            totalSeconds = int.Parse(Console.ReadLine());
            hours = totalSeconds / 3600;
            minutes = (totalSeconds % 3600) / 60;
            seconds = totalSeconds % 60;

            // In kết quả
            Console.WriteLine($"Định dạng: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
