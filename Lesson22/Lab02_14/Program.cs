namespace Lab02_15
{
    internal class Program
    {
        /// <summary>
        /// Chương trình lãi ngân hàng
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            int months;
            decimal principal, annualInterestRate, monthlyInterestRate;

            // Nhập thông tin
            Console.Write("Nhập số tiền gốc (VND): ");
            principal = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất năm (%): ");
            annualInterestRate = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
             months = int.Parse(Console.ReadLine());

            // Tính lãi suất tháng
             monthlyInterestRate = (annualInterestRate / 12) / 100;

            // Tính tổng tiền cuối kỳ
            for (int i = 1; i <= months; i++)
            {
                decimal interest = principal * monthlyInterestRate;
                principal += interest;
                Console.WriteLine($"Tháng {i}: Số tiền gốc + lãi = {principal:C}, Tiền lãi tháng = {interest:C}");
            }
        }
    }
}
