namespace Lab05_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chi = { "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            // Base year: 2010 is Canh Dần
            int baseYear = 2010;

            Console.Write("Nhập vào một năm bất kỳ: ");
            int year = int.Parse(Console.ReadLine());

            int canIndex = (year - baseYear + 10) % 10;
            int chiIndex = (year - baseYear + 12) % 12;

            Console.WriteLine($"Năm {year} là năm {can[canIndex]} {chi[chiIndex]}.");
        }
    }
}
