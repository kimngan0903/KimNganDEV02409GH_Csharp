using System.Collections;
using System.Collections.Generic;

namespace KiemTra
{
    public class Program
    {

        // HashTabe để lưu sinh viên
        static Hashtable studentTable = new Hashtable();
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chon = 0;
            do
            {
                menu();
                Console.Write("Option: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1. Insert new sudent...");
                        InsertStudent();
                        break;
                    case 2:
                        Console.WriteLine("2.Display all the student list...");
                        DisplayStudents();
                        break;
                    case 3:
                        Console.WriteLine("3. Calculator average mark...");
                        CalculateAvgMarks();
                        break;
                    case 4:
                        Console.WriteLine("4.Exit");
                        break;
                    default:
                        Console.WriteLine("Bạn đã chọn sai, vui lòng chọn lại!");
                        break;
                }
            }
            while (chon != 4);

            // Menu
            static void menu()
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Insert new sudent...");
                Console.WriteLine("2. Display all the student list...");
                Console.WriteLine("3. Calculator average mark...");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("=========================");
            }

            // Thêm mới sinh viên
            static void InsertStudent()
            {
                Student student = new Student();
                Console.Write("Input Student ID: ");
                student.StudID = int.Parse(Console.ReadLine());
                Console.Write("Input Student Name: ");
                student.StudName = Console.ReadLine();
                Console.Write("Input Student Gender: ");
                student.StudGender = Console.ReadLine();
                Console.Write("Input Student Age: ");
                student.StudAge = int.Parse(Console.ReadLine());
                Console.Write("Input Student Class: ");
                student.StudClass = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Input mark {i + 1}: ");
                    student[i] = int.Parse(Console.ReadLine());
                }
                // Tính điểm trung bình
                student.CalAvg();

                // Thêm sinh viên vào hashtable
                studentTable[student.StudID] = student;
                Console.WriteLine("Student added successfully.");
            }

            // Hàm hiển thị danh sách sinh viên
            static void DisplayStudents()
            {
                foreach (Student student in studentTable.Values)
                {
                    student.Print();
                }
            }

            // Hàm tính và in điểm trung bình của tất cả các sinh viên
            static void CalculateAvgMarks()
            {
                foreach (Student student in studentTable.Values)
                {
                    Console.WriteLine("Mark: {0:N2}", student.StudAvgMark);
                    Console.WriteLine();
                }
            }
        }
    }
}
