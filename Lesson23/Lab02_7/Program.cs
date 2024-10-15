namespace Lab02_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo biến
            string id;
            string name;
            string address;
            DateTime birthday;
            decimal salary, bonus, totalSalary;

            // Nhập thông tin
            Console.Write("Nhập mã nhân viên: ");
            id = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập lương: ");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nhập thưởng: ");
            bonus = Convert.ToDecimal(Console.ReadLine());

            // Tổng lương
            totalSalary = salary + bonus;

            // In ra màn hình
            Console.WriteLine("\n ---Thông tin nhân viên---");
            Console.WriteLine("Mã nhân viên: {0}", id);
            Console.WriteLine("Tên nhân viên: " + name);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("Ngày sinh: {0:dd/MM/yyyy}", birthday);
            Console.WriteLine("Lương: {0}", salary);
            Console.WriteLine("Thưởng: {0}", bonus);
            Console.WriteLine("Tổng lương: {0}", totalSalary);
        }
    }
}
