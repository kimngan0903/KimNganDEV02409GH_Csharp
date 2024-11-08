using System.Collections;

namespace Lab06_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một hashtable
            Hashtable weekDays = new Hashtable();
            weekDays.Add(1, "Monday");
            weekDays.Add(2, "Tuesday");
            weekDays.Add(3, "Wednesday");
            weekDays.Add(4, "Thursday");
            weekDays.Add(5, "Friday");
            weekDays.Add(6, "Saturday");
            weekDays.Add(7, "Sunday");

            // Tìm ngày Tuesday
            if (weekDays.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Tuesday is in the hashtable.");
            }
            else
            {
                Console.WriteLine("Tuesday is not found.");
            }

            // In ra các phần tử bao gồm key và value
            Console.WriteLine("Days of the week:");
            foreach (DictionaryEntry day in weekDays)
            {
                Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
            }
        }
    }
}
