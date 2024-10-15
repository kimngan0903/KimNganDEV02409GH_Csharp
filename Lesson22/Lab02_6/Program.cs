namespace Lab02_7
{
    internal class Program
    {
        /// <summary>
        /// Sử dụng foreach in ra danh sách các phần tử mảng
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo mảng tên
            string[] names = {"Phuc", "Tai", "Loc", "Dao"};
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var n in names)
            {  
                Console.WriteLine(n);
            }
        }
    }
}
