namespace Lab05_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo mảng gồm 10 phần tử
            Console.WriteLine("Tạo ứng dụng C# và thực hiện các chức năng sau:");
            int[] arrays = { 11, 21, -31, 42, 24, 55, -33, -32, 67, 98 };

            int chon = 0;
            do
            {
                menu();
                Console.Write("Mời bạn chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- Tìm phần tử nhỏ nhất của mảng.");
                        int min = minArray(arrays);
                        Console.WriteLine("Min: {0}", min);
                        break;
                    case 2:
                        Console.WriteLine("2- Đảo ngược mảng.");
                        //Console.WriteLine("Array: {0}", String.Join("  ", arrays));
                        //Array.Reverse(arrays);
                        //Console.WriteLine("Reverse: " + String.Join("  ", arrays));
                        ReverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3- Sắp xếp mảng tăng hoặc giảm.");
                        SortArray(arrays);
                        ReverseArray(arrays);
                        break;
                    case 4:
                        Console.WriteLine("4- Tìm phần tử là số nguyên.");
                        PrintPrime(arrays);
                        break;
                    case 5:
                        Console.WriteLine("5- In ra số lượng các số dương liên tiếp nhiều nhất.");
                        int max = MaxCountPositiveNumber(arrays);
                        Console.WriteLine("Max positive number: " + max);
                        break;
                    case 6:
                        Console.WriteLine("6 - Tính TBC các phần tử dương.");
                        break;
                    case 7:
                        Console.WriteLine("7- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xem nhau không?");
                        break;
                    case 8:
                        Console.WriteLine("8 - Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng!");
                        break;
                }
            }
            while (chon != 8);
        }

        // Menu chức năng của ứng dụng
        static void menu()
        {
            Console.WriteLine("==============MENU==============");
            Console.WriteLine(
                "1- Tìm phần tử nhỏ nhất của mảng. \n" +
                "2- Đảo ngược mảng.\n" +
                "3- Sắp xếp mảng tăng hoặc giảm.\n" +
                "4- Tìm phần tử là số nguyên.\n" +
                "5- In ra số lượng các số dương liên tiếp nhiều nhất.\n" +
                "6- Tính TBC các phần tử dương.\n" +
                "7- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xem nhau không?.\n" +
                "8- Kết thúc."
            );
        }

        /// <summary>
        /// 1- Tìm phần tử nhỏ nhất của mảng.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>int</returns>
        static int minArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(min > arr[i])
                    min = arr[i];
            }
            return min;
        }
        
        /// <summary>
        /// 2- Đảo ngược mảng
        /// </summary>
        /// <param name="arr"></param>
        static void ReverseArray(int[] arr)
        {
            Console.WriteLine("Array: {0}", String.Join("  ", arr));
            Array.Reverse(arr);
            Console.WriteLine("Reverse: " + String.Join("  ", arr));
        }
        
        /// <summary>
        /// 3- Sắp xếp mảng tăng hoặc giảm
        /// </summary>
        /// <param name="arr"></param>
        static void SortArray(int[] arr)
        {
            Console.WriteLine("Mảng trước khi sắp: {0}", String.Join("  ", arr));
            Array.Sort(arr);
            Console.WriteLine("Sorted: {0}", String.Join("  ", arr));
        }

        /// <summary>
        /// 4- Tìm phần tử là số nguyên tố
        /// </summary>
        /// <param name="arr"></param>
        static void PrintPrime(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]) == true)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// IsPrime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 5- In ra số lượng các số dương liên tiếp nhiều nhất.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>int</returns>
        static int MaxCountPositiveNumber(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0; // Reset đếm khi gặp số không dương
                }
            }
            return maxCount;
        }


    }
}
