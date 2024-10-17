namespace Lab05_2
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh họa một số thao tác trên mảng 2 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo và khởi tạo mảng
            int[,] a =
            {
                {4, 6, 9 },
                {2, 4, 6 },
                {9, 2, 6 },
                {1, 6, 3 }
            };

            // Duyệt mảng và in theo hàng cột
            Console.WriteLine("Nội dung mảng: ");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.WriteLine(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            // Tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Các phần tử có chỉ số hàng bằng chỉ số cột: ");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1);j++)
                {
                if (i == j) 
                        Console.Write(" {0} ", a[i, j]);
                }
            }

            // Các phần tử lớn nhất trên hàng
            Console.WriteLine("Các phần tử lớn nhất trên hàng");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                }
                Console.WriteLine("Hàng {0}:{1}", i, max);
            }
        }
    }
}
