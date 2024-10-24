namespace Lab08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo Customer
            var customers = new Customer[]
            {
                new Customer{Id = 5, Name = "Sam"},
                new Customer{Id = 6, Name = "Dave"},
                new Customer{Id = 7, Name = "Julia" },
                new Customer{Id = 8, Name = "Sue" }
            };

            // Khởi tạo Order
            var orders = new Order[]
            {
                new Order{Id = 1, Product = "Book" },
                new Order{Id = 2, Product = "Game" },
                new Order{Id = 3, Product = "Computer" },
                new Order{Id = 4, Product = "Shirt" }
            };

            // Sử dụng truy vấn và join 2 tập dữ liệu dựa trên ID
            var query = from c in customers
                         join o in orders on c.Id equals o.Id
                         select new { c.Name, o.Product };

            // Hiển thị tên khách hàng và nhóm sản phẩm
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);   
            }
        }
    }
}
