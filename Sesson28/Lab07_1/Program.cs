using Store;
namespace Lab07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();

            // Gán giá trị
            dealer.Name = "Coca cola";
            dealer.Email = "cocacolap@gmail.com";
            dealer.Phone = "1234567890";

            // In thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);

            // Tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();

            // Gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;

            // In thông tin
            Console.WriteLine("Store Inventory");
            Console.WriteLine();

        }
    }
}
