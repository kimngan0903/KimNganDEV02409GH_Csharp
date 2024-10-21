﻿using System.Collections;

namespace Lab06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo ArrayList
            ArrayList inv = new ArrayList();

            // Thêm phần tử danh sách
            inv.Add(new Product(" A", 5.9, 3));
            inv.Add(new Product(" B", 8.2, 2));
            inv.Add(new Product(" C", 3.5, 4));
            inv.Add(new Product(" D", 1.8, 8));

            // In ra danh sách phần tử
            Console.WriteLine("Product list: ");
            foreach (Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}
