namespace Lab02_12
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các hình
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Hình a
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Hình b
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(new string('S', 9));
            }

            // Hình c
            for (int i = 1, k = 0; i <= 5; ++i, k = 0)
            {
                for (int space = 1; space <= 5 - i; ++space)
                {
                    Console.Write("  ");
                }

                while (k != 2 * i - 1)
                {
                    Console.Write("* ");
                    ++k;
                }

                Console.WriteLine();
            }
        }
    }
}
