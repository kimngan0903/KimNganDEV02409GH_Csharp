namespace Lab04_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            NhanVienBanHang nvbh = new NhanVienBanHang();
            Console.WriteLine("Nhân viên bán hàng");
            nvbh.HienThi("YYY", "Hải Phòng");
            Console.WriteLine("Lương: {0}", nvbh.TinhLuong(30, 1500));
            CongNhan cn = new CongNhan();
            Console.WriteLine("công nhân");
            cn.HienThi("HHH", "Hà Nội");
            Console.WriteLine("Lương: {0}", cn.TinhLuong(123, 454));

            Console.ReadKey();
        }
    }
}
