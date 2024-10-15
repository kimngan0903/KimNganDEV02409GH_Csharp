namespace Lab02_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập thông tin
            Console.Write("Nhập số tiền gửi: ");
            double soTienGui = double.Parse(Console.ReadLine());
            Console.Write("Nhập lãi suất ngân hàng (tính theo năm) (%): ");
            double laiSuatNam = double.Parse(Console.ReadLine())/100;
            Console.Write("Nhập số tháng gửi: ");
            int soThangGui = int.Parse(Console.ReadLine());

            double laiSuatThang = laiSuatNam / 12;
            double soDu = soTienGui;
            Console.WriteLine("Tháng\t Số dư \t Lãi");
            for (int thang = 1; thang <= soThangGui; thang++)
            {
                double lai = soDu * laiSuatThang;
                soDu += lai;
                Console.WriteLine($"{thang}\t{soDu:N2} \t{lai:N2}");
            }
            double tongLai = soDu - soTienGui;
            Console.WriteLine($"Tổng lãi sau {soThangGui} tháng:{tongLai:N2}");
        }
    }
}
