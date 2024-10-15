namespace Lab01_4
{
    /// <summary>
    /// Author  : Kim Ngân
    /// Date    : 14/10/2024
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra thông tin nhân viên
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Viết chương trình thực hiệnn các yêu cầu");
            // Khai báo biến
            string maNV;
            string hoVaTen;
            DateTime ngaySinh;
            string diaChi;
            string dienThoai;
            string email;

            // Gắn giá trị
            maNV = "NV001";
            hoVaTen = "Nguyen Van A";
            ngaySinh = DateTime.Now;
            diaChi = "Ha Noi";
            dienThoai = "0123456789";
            email = "a123@gmail.com";

            // In
            Console.WriteLine("----Thông tin nhân viên---- ");
            Console.WriteLine("Mã nhân viên: " + maNV);
            Console.WriteLine("Họ tên nhân viên: {0}" , hoVaTen);
            Console.WriteLine("Ngày sinh: {0}" ,String.Format("{0:dd/MM/yyyy}" , ngaySinh));
            Console.WriteLine("Địa chỉ: " + diaChi);
            Console.WriteLine("Điện thoại: " + dienThoai);
            Console.WriteLine("Email: {0}" , email);
        }
    }
}
