namespace Lab08_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo mảng 10 quyển sách
            List<Book> books = new List<Book>
            {
                new Book(1, "C# Programming", "Author A", 15000, "Education", 2015),
                new Book(2, "Java Programming", "Author B", 12000, "Education", 2018),
                new Book(3, "Python Basics", "Author C", 30000, "Tech Books", 2015),
                new Book(4, "Advanced Algorithms", "Author D", 4000, "Tech Books", 2017),
                new Book(5, "Lập trình Web", "Author E", 2500, "Giáo Dục", 2020),
                new Book(6, "Introduction to AI", "Author F", 45000, "Research Press", 2019),
                new Book(7, "Data Science", "Author G", 5000, "Tech Books", 2015),
                new Book(8, "Database Systems", "Author H", 16000, "Education", 2013),
                new Book(9, "Lập trình C#", "Author I", 2000, "Giáo Dục", 2015),
                new Book(10, "Machine Learning", "Author J", 35000, "Research Press", 2021)
            };

            // 1. Hiển thị tất cả các quyển sách
            Console.WriteLine("Hiển thị tất cả các quyển sách: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            // 2. Hiển thị những quyển sách có giá từ 1000-5000
            Console.WriteLine("\nHiển thị những quyển sách có giá từ 1000-5000: ");
            var booksPriceRange = books.Where(b => b.Price >= 1000 && b.Price <= 5000);
            foreach (var book in booksPriceRange)
            {
                Console.WriteLine(book);
            }

            // 3. Hiển thị những quyển sách xuất bản năm 2015
            Console.WriteLine("\nHiển thị những quyển sách xuất bản năm 2015: ");
            var books2015 = books.Where(b => b.Year == 2015);
            foreach (var book in books2015)
            {
                Console.WriteLine(book);
            }

            // 4. Hiển thị những quyển sách có tên Lập trình
            Console.WriteLine("\n Hiển thị những quyển sách có tên Lập trình: ");
            var booksWithLapTrinh = books.Where(b => b.Name.Contains("Lập trình"));
            foreach (var book in booksWithLapTrinh)
            {
                Console.WriteLine(book);
            }

            // 5. Đếm các quyển sách của nhà xuất bản Giáo dục
            int countGiaoDuc = books.Count(b => b.Publisher == "Giáo Dục");
            Console.WriteLine("\nĐếm các quyển sách của nhà xuất bản Giáo dục: " + countGiaoDuc);
        }
    }
}
