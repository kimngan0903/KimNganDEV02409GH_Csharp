namespace Lab03_4
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh họa việc sử dụng từ khóa ref và out
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a = 20, b = 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Trước khi hoán vị a={0}, b={1}", a, b);
            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoán vị đang fake a={0}, b={1}", a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoán vị đang really a={0}, b={1}", a, b);
            u.AreaCircle(100, out area);
            Console.WriteLine("Chu vi hình tròn bán kính 100 là: {0}", area);
        }
    }
}
