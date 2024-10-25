namespace Lab08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo chung
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words =
                {
                    "Chỉ", "trích", "phê", "phán", "người", "khác", "giống", "như", "con", "chim", "bồ", "câu", "đưa", "thư", "bao", "giờ", "cũng", "quay", "về", "nơi", "xuất", "phát"
                };

            List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId = "F01", FilmName = "Điệp viên 007", Price = 120000},
                new Film{FilmId = "F02", FilmName = "Tam quốc diễn nghĩa", Price = 130000},
                new Film{FilmId = "F03", FilmName = "Thiếu lâm truyền kỳ", Price = 16000},
                new Film{FilmId = "F04", FilmName = "Người nhện 2", Price = 100000},
                new Film{FilmId = "F05", FilmName = "Ngân hàng tình yêu", Price = 340000},
                new Film{FilmId = "F06", FilmName = "Người đẹp và quái thú", Price = 230000},
                new Film{FilmId = "F07", FilmName = "Biệt động Sài Gòn", Price = 190000},
            };

            // Lọc các sỗ chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber, "Lọc các số chẵn: ");
            Console.WriteLine("============================");

            // Lọc các ký tự có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Lọc các từ có độ dài > 4: ");
            Console.WriteLine("============================");

            // Lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("T"));
            Show<string>(queryT, "Lọc các từ có tên bắt đầu bằng chữ t: ");
            Console.WriteLine("============================");

            // Lọc các số duy nhất trong tập hợp các số
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "Lọc các số duy nhất trong tập hợp các số: ");
            Console.WriteLine("============================");

            // Đếm xem có bao nhiêu từ không trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Đếm xem có bao nhiêu từ không trùng nhau: " + countDistinct);
            Console.WriteLine("============================");

            // Lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "Lấy 4 số đầu tiên trong dãy: ");
            Console.WriteLine("============================");

            // Lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "Lấy 2 từ đầu tiên trong câu: ");
            Console.WriteLine("============================");

            // Lấy những từ đầu tiên có chứa chữ t
            var searchword = Words.TakeWhile(w => w.Contains('t'));
            Show<string>(searchword, "Lấy những từ đầu tiên có chứa chữ t: ");
            Console.WriteLine("============================");

            // Sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000
            var queryfilm = ListFilm.OrderBy(f => f.Price).Select(x => new { x.FilmId, x.FilmName, x.Price }).ToList().TakeWhile(t => t.Price < 200000);
            Console.WriteLine("Sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000: " + queryfilm);
            Console.WriteLine("============================");

            // Bỏ qua 3 phần tử đầu tiên, lấy tất cả phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bỏ qua 3 phần tử đầu tiên, lấy tất cả phần tử còn lại: ");
            Console.WriteLine("============================");

            // Bỏ qua 4 phần tử đầu tiên, lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bỏ qua 4 phần tử đầu tiên, lấy 3 phần tử kế tiếp: ");
            Console.WriteLine("============================");

            // Bỏ qua 3 phím đầu tiên, lấy 3 phím kế tiếp (có thể áp dụng để phân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "Bỏ qua 3 phím đầu tiên, lấy 3 phím kế tiếp: ");
            Console.WriteLine("============================");

            // Sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortName = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortName, "Sắp xếp giảm dần, sau đó lấy các phần tử <5: ");
            Console.WriteLine("============================");

            // Định nghĩa phương thức Generic hiển thị dữ liệu
            static void Show<T>(IEnumerable<T> data, string message)
            {
                Console.WriteLine(message);
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
