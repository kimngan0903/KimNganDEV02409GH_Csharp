namespace Lab07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo mới đối tượng House trong namespace Business
            // Bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.House h = new Business.House();

            // Gán thông tin
            h.HouseNo = "D294EF";
            h.Price = 425880;

            // In thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No: " + h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);

            // Tạo mới đối tượng car trong namespace Business.Dealership
            // Bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;

            // In thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No: " + h.HouseNo);
            Console.WriteLine("\t Price: " + h.Price);
        }
    }
}
