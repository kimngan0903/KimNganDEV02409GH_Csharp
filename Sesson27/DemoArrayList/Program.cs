using System.Collections;

namespace DemoArrayList
{
    internal class Program
    {
        /// <summary>
        /// ArrayList
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Demo ArrayList");

            // Khởi tạo
            ArrayList arrayList = new ArrayList();

            // Thêm các phần tử
            // Add
            arrayList.Add(111);
            arrayList.Add("Ruby");

            // Add Range
            string[] strs = { "Tùng", "Cúc", "Hoa", "Trúc", "Mai" };
            arrayList.AddRange(strs);

            // In mảng
            printArray(arrayList);

            // Insert
            arrayList.Insert(0, "Devmaster");
            printArray(arrayList);

            // Remove
            arrayList.Remove("Devmaster");
            printArray(arrayList);

            arrayList.RemoveAt(1);
            printArray(arrayList);

            // Sort
            arrayList.AddRange(strs);
            printArray(arrayList);

            arrayList.Sort();
            printArray(arrayList);
        }
        static void printArray(ArrayList arrayList)
        {
            Console.WriteLine("Danh sách các phần tử: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================");
        }
    }
}
