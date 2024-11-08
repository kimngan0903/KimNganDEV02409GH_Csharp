namespace Lab05_5_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo một mảng 1 chiều gồm 10 phần tử Student.
            Student[] students = new Student[10];
            students[0] = new Student(1, "Alice", 20);
            students[1] = new Student(2, "Bob", 19);
            students[2] = new Student(3, "Charlie", 21);
            students[3] = new Student(4, "David", 22);
            students[4] = new Student(5, "Eva", 18);
            students[5] = new Student(6, "Frank", 23);
            students[6] = new Student(7, "Grace", 20);
            students[7] = new Student(8, "Hannah", 19);
            students[8] = new Student(9, "Ian", 24);
            students[9] = new Student(10, "Jack", 22);

            int choice = 0;
            do
            {
                menu();
                Console.Write("Mời bạn chọn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1- Tìm phần tử student có tuổi nhỏ nhất của mảng.");
                        Student youngest = FindYoungestStudent(students);
                        Console.WriteLine($"Youngest Student: {youngest.Name}, Age: {youngest.Age}");
                        break;
                    case 2:
                        Console.WriteLine("2- Sắp xếp mảng tăng dần theo tuổi sinh viên (student).");
                        SortStudentsByAge(students);
                        Console.WriteLine("Students sorted by age:");
                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{student.Name}, Age: {student.Age}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("3- Tìm sinh viên có tuổi lớn nhất.");
                        Student oldest = FindOldestStudent(students);
                        Console.WriteLine($"Oldest Student: {oldest.Name}, Age: {oldest.Age}");
                        break;
                    case 4:
                        Console.WriteLine("4- Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng!");
                        break;
                }
            }
            while (choice != 4);
        }

        // Menu chức năng của ứng dụng
        static void menu()
        {
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1- Tìm phần tử student có tuổi nhỏ nhất của mảng.");
            Console.WriteLine("2- Sắp xếp mảng tăng dần theo tuổi sinh viên (student).");
            Console.WriteLine("3- Tìm sinh viên có tuổi lớn nhất.");
            Console.WriteLine("4- Kết thúc.");
        }

        /// <summary>
        /// 1- Tìm phần tử student có tuổi nhỏ nhất của mảng.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        static Student FindYoungestStudent(Student[] students)
        {
            Student youngest = students[0];
            foreach (Student student in students)
            {
                if (student.Age < youngest.Age)
                {
                    youngest = student;
                }
            }
            return youngest;
        }

        /// <summary>
        /// 2- Sắp xếp mảng tăng dần theo tuổi sinh viên (student).
        /// </summary>
        /// <param name="students"></param>
        static void SortStudentsByAge(Student[] students)
        {
            Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
        }

        /// <summary>
        /// 3- Tìm sinh viên có tuổi lớn nhất.
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        static Student FindOldestStudent(Student[] students)
        {
            Student oldest = students[0];
            foreach (Student student in students)
            {
                if (student.Age > oldest.Age)
                {
                    oldest = student;
                }
            }
            return oldest;
        }
    }
}