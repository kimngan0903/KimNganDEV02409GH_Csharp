namespace Lab06_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo 1 list lưu trữ danh sách 10 Car
            List<Car> cars = new List<Car>
            {
                new Car("Mitsubishi Xforce ", "Red"),
                new Car("Ford Ranger", "Blue"),
                new Car("Mazda CX-5", "Red"),
                new Car("Toyota Vios", "Green"),
                new Car("Mitsubishi Xpander", "Black"),
                new Car("Hyundai Accent", "Red"),
                new Car("Toyota Yaris Cross", "White"),
                new Car("Ford Everest", "Yellow"),
                new Car("Hyundai Creta", "Red"),
                new Car("Toyota Corolla Cross", "Blue")
            };

            // Xóa các Car có màu Red
            cars.RemoveAll(c => c.Color == "Red");
            Console.WriteLine("Xe ô tô sau khi loại bỏ Xe màu đỏ: ");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("==========================================");

            // In danh sách các Car
            Console.WriteLine("\nDanh sách xe còn lại: ");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("==========================================");
        }
    }
}
