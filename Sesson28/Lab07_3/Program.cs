namespace Lab07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo mảng
            byte[] a = new byte[5];

            // Nhập mảng
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("a[{0}]= ", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                // Console.Write(ex.Message);
                Console.WriteLine("Không được nhập ký tự cho mảng số");
            }
            catch (OverflowException ex)
            {
                // Console.Write(ex.Message);
                Console.WriteLine("Không được nhập ký tự nằm ngoài miền 0-255");
            }
            catch (IndexOutOfRangeException ex) 
            {
                // Console.Write(ex.Message);
                Console.WriteLine("Lỗi vượt quá phạm vi của mảng");
            }

            // In mảng
            Console.WriteLine("Nội dung mảng");
            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);
        }
    }
}
