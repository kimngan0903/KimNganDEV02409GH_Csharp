namespace Lab06_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo 1 collection gồm 10 quyển sách
            List<Book> books = new List<Book>
            {
                new Book(1, "Khi trai đẹp hẹn hò ", "ANana Aokawa", "Nhi Dong", 2010, 50),
                new Book(2, "Đắc Nhân Tâm", " Dale Carnegie", "Publisher 2", 2014, 75),
                new Book(3, "Cuốn Theo Chiều Gió ", " Margaret Mitchell", "Publisher 3", 2015, 60),
                new Book(4, "Đường về nhà", "Phạm Quang Phúc, Trang Hoàng", "Nhi Dong", 2016, 80),
                new Book(5, "Nhà Giả Kim", "Paulo Coelho", "Publisher 5", 2014, 55),
                new Book(6, "Bố Già", "Mario Puzo", "Publisher 6", 2010, 90),
                new Book(7, "Ông Già Và Biển Cả", "Ernest Hemingway", "Publisher 7", 2020, 45),
                new Book(8, "Hoàng Tử Bé ", "Antoine de Saint-Exupéry", "Publisher 8", 2010, 100),
                new Book(9, "Chiến Tranh Và Hòa Bình", "Leo Tolstoy", "Publisher 9", 2019, 70),
                new Book(10, "Cuộc Đời Của Pi ", "Yann Martel", "Publisher 10", 2021, 85)
            };

            // In danh sách các quyển sách tăng dần theo giá
            var sortedBooks = books.OrderBy(b => b.Price).ToList();
            Console.WriteLine("Danh sách các quyển sách tăng dần theo giá: ");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("==========================================");

            // Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
            Console.WriteLine("\nNhập tên sách để tìm kiếm:");
            string searchTitle = Console.ReadLine();
            var foundBook = books.FirstOrDefault(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                Console.WriteLine("Đã tìm thấy sách: {0}", foundBook);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách.");
            }
            Console.WriteLine("==========================================");

            // Đưa ra những sách xuất bản năm 2014
            Console.WriteLine("\nSách xuất bản năm 2014:");
            var books2014 = books.Where(b => b.Year == 2014).ToList();
            foreach (var book in books2014)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("==========================================");

            // Xóa những quyển sách của nhà xuất bản "Nhi Dong"
            books.RemoveAll(b => b.Publisher == "Nhi Dong");
            Console.WriteLine("\nSách sau khi gỡ bỏ nhà xuất bản Nhi Đồng:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("==========================================");
        }
    }
}
