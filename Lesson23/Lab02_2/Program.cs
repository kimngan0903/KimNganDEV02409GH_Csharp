namespace Lab02_3
{
    internal class Program
    {
        /// <summary>
        /// Nhập vào 1 ký tự, in ra ký tự đó là nguyên âm hay phụ âm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char ch;
            Console.WriteLine("Nhập vào ký tự: ");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} là nguyên âm.", ch);
                    break;
                default:
                    Console.WriteLine("{0} là phụ âm.", ch);
                    break;
            }
        }
    }
}
