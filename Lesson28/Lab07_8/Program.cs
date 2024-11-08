namespace Lab07_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Lecture lecture = new Lecture();

            Console.Write("Nhap name:", lecture.Name);
            lecture.Name = Console.ReadLine();
            Console.Write("Nhap salary:", lecture.Salary);
            lecture.Salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap bonus:", lecture.Bonus);
            lecture.Bonus = Convert.ToInt32(Console.ReadLine());

            lecture.Display();
            try
            {

                if (lecture.Salary < 60000)
                {
                    throw new AmountException("low salary:" + lecture.Salary);
                }
                if (lecture.Bonus > 10000)
                {
                    throw new AmountException("Hight Bonus:" + lecture.Bonus);
                }
                Console.WriteLine("everything is in order");
            }
            catch (AmountException e)
            {
                Console.WriteLine("error:" + e.Message);
            }
        }
    }
}
