namespace Lab03_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book b1 = new Book();
            Book b2 = new Book("Phạm Thị Kim Ngân", 10, "VN", "Mắt biếc", 50);
            b1.Display();
            b2.Display();

            b1.flipPageForWard();
            b2.flipPageBackWard();
            Console.ReadKey();
        }
    }
}
