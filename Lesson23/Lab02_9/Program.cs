namespace Lab02_9
{
    internal class Program
    {
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
            minutes = (totalSeconds % 3600 ) / 60;
            seconds = (totalSeconds % 60);

            // In thông tin 
            Console.WriteLine($"Định dạng: {hours:0}:{minutes:0}:{seconds:0}");
        }
    }
}
