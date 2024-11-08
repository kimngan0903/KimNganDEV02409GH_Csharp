namespace Lab06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo sortedlist generic
            SortedList<string, string> listEm = new SortedList<string, string>();

            // Đưa dữ liệu vào
            listEm.Add("E01", "Trần Thị Thủy");
            listEm.Add("E02", "Lê Hải Hà");
            listEm.Add("E03", "Nguyễn Văn Hùng");
            listEm.Add("E04", "Hoàng Thị Thơm");
            listEm.Add("E05", "Trịnh Văn Chiến");

            // In danh sách
            Console.WriteLine("---Danh sách nhân viên---");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }

            // Tìm kiếm tất cả các nhân viên có tên bắt đầu bằng chữ Th
            Console.WriteLine("Danh sách nhân viên bắt đầu bằng chữ Th");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Th"))
                    Console.WriteLine(key + ":" + listEm[key]);
            }

            // Xóa nhân viên có mã E04
            listEm.Remove("E04");

            // Kiểm tra nếu chưa có nhân viên E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyễn Hoài Linh");

            // In danh sách sau khi xóa, thêm
            Console.WriteLine("Danh sách nhân viên sau khi xóa, thêm");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }
    }
}
