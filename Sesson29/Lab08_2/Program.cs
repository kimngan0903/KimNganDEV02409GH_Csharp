namespace Lab08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo Customer
            var customers = new Customer[]
            {
                new Customer{ID = 5, Name = "Sam"},
                new Customer{ID = 6, Name = "Dave"},
                new Customer{ID = 7, Name = "Julia" },
                new Customer{ID = 8, Name = "Sue" }
            };

            // Khởi tạo Order
            var orders = new Order[]
            {
                new Order{ID = 1, Product = "Book" },
                new Order{ID = 2, Product = "Game" },
                new Order{ID = 3, Product = "Computer" },
                new Order{ID = 4, Product = "Shirt" }
            };

            // Sử dụng truy vấn và join 2 tập dữ liệu dựa trên ID
            var query = from c in customers
                         join o in orders on c.ID equals o.ID
                         select new { c.Name, o.Product };

            // Hiển thị tên khách hàng và nhóm sản phẩm
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);   
            }
        }
    }
}
