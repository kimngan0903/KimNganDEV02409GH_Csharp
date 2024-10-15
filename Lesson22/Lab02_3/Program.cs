namespace Lab02_4
{
    internal class Program
    {
        /// <summary>
        /// Chương trình giải phương trình bậc 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo các biến
            double a, b, c, delta, x1, x2;

            // Nhập a, b, c
            Console.WriteLine("a = ");

            // a phải !=0
            do
            {
                a = Convert.ToUInt32(Console.ReadLine());
            }
            while (a == 0);
            Console.WriteLine("b = ");
            b = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("c = ");
            c = Convert.ToUInt32(Console.ReadLine());

            // Tính delta
            delta = b * b - 4 * a * c;

            // Biện luận
            if (delta < 0) 
                Console.Write("Phương trình vô nghiệm");
                else if (delta == 0) {
                    Console.WriteLine("Phương trình có nghiệm kép");
                    Console.WriteLine("x1=x2={0}", -b / (2 * a));
                } else {
                    Console.WriteLine("Phương trình có 2 nghiệm");
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1= {0}", x1);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x2= {0}", x2);
                }
        }
    }
}
