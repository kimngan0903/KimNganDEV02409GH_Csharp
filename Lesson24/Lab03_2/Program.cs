namespace Lab03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();

            // Gán giá trị cho ct1
            ct1.Id = 9;
            ct1.Firstname = "Phạm Thị";
            ct1.Lastname = "Kim Ngân";
            ct1.Address = "Hải Phòng";
            ct1.Phone = "0373993662";
            ct1.Email = "ngan36758@gmail.com";

            // Tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(3, "Con", "Lợn Nhựa", "Hải Phòng", "0123456789", "lonnhua@gmail.com");

            // Hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}
