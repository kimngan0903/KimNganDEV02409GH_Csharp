namespace Lab05_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[,] array = new int[4, 4]
                {
                    { 7, 8, 9, 10 },
                    { 12, 13, 14, 15 },
                    { 22, 23, 24, 25 },
                    { 32, 33, 34, 35 }
                };

            int chon = 0;
            do
            {
                menu();
                Console.Write("Mời bạn chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- In mảng theo hàng cột.");
                        PrintArray(array);
                        break;
                    case 2:
                        Console.WriteLine("2- Tính tổng các phần tử trên đường chéo.");
                        int sum = SumDiagonal(array);
                        Console.WriteLine($"Tổng các phần tử trên đường chéo: {sum}");
                        break;
                    case 3:
                        Console.WriteLine("3- Liệt kê các phần tử chia hết cho 7.");
                        ListDivisibleBy7(array);
                        break;
                    case 4:
                        Console.WriteLine("4- In ra phần tử nhỏ nhất trên cột");
                        int minColValue = FindMinInColumn(array);
                        Console.WriteLine($"Phần tử nhỏ nhất trên cột là: {minColValue}");
                        break;
                    case 5:
                        Console.WriteLine("5- Tìm tổng các phần tử nằm trên đường viền của mảng.");
                        int borderSum = SumBorderElements(array);
                        Console.WriteLine($"Tổng các phần tử nằm trên đường viền là: {borderSum}");
                        break;
                    case 6:
                        Console.WriteLine("6- Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.");
                        ConvertTo1DAndSort(array);
                        break;
                    case 7:
                        Console.WriteLine("7- Kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng!");
                        break;
                }
            } while (chon != 7);
        }

        static void menu()
        {
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("1- In mảng theo hàng cột.");
            Console.WriteLine("2- Tính tổng các phần tử trên đường chéo.");
            Console.WriteLine("3- Liệt kê các phần tử chia hết cho 7.");
            Console.WriteLine("4- In ra phần tử nhỏ nhất trên cột.");
            Console.WriteLine("5- Tìm tổng các phần tử nằm trên đường viền của mảng.");
            Console.WriteLine("6- Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.");
            Console.WriteLine("7- Kết thúc.");
        }

        /// <summary>
        /// 1- In mảng theo hàng cột.
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 2- Tính tổng các phần tử trên đường chéo.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int SumDiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        /// <summary>
        /// 3- Liệt kê các phần tử chia hết cho 7.
        /// </summary>
        /// <param name="array"></param>
        static void ListDivisibleBy7(int[,] array)
        {
            Console.WriteLine("Các phần tử chia hết cho 7: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 7 == 0)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 4- In ra phần tử nhỏ nhất trên cột.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int FindMinInColumn(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// 5- Tìm tổng các phần tử nằm trên đường viền của mảng.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int SumBorderElements(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// 6- Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.
        /// </summary>
        /// <param name="array"></param>
        static void ConvertTo1DAndSort(int[,] array)
        {
            int[] oneDimArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    oneDimArray[index++] = array[i, j];
                }
            }
            Array.Sort(oneDimArray);
            Console.WriteLine("Mảng sau khi chuyển thành 1 chiều và sắp xếp: " + string.Join(", ", oneDimArray));
        }
    }
}        

