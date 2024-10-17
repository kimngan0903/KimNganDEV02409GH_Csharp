namespace Lab05_1
{
    internal class Program
    {
        /// <summary>
        /// Một số thao tác với mảng 1 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo và khởi tạo mảng 1 chiều
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };

            // Duyệt mảng và in dữ liệu
            Console.WriteLine("Các phần tử của mảng");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(" {0} ", m[i]);
            }

            // Tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất: " + max);

            // Kiểm tra mảng có đối xứng không
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }

            if (kt)
                Console.WriteLine("Mảng đối xứng");
            else
                Console.WriteLine("Mảng không đối xứng");
        }
    }
}
