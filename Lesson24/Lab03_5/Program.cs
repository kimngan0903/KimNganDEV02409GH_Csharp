namespace Lab03_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đối tượng nhân viên
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Phạm Thị Kim Ngân";
            emp.salaryLevel = 50;
            emp.basicSalary = 300;
            emp.Display();
            double InCome = emp.getInCome();

            // Hiển thị thông tin nhân viên
            Console.WriteLine("Thu nhập: {0}", InCome);
            Console.ReadKey();
        }
    }
}
