namespace Lab05_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department("IT", 3);
            dep[0] = new Employee(1, "Alice", 25);
            dep[1] = new Employee(2, "Bob", 30);
            dep[2] = new Employee(3, "Charlie", 35);

            Console.WriteLine($"Department: {dep.Name}");
            for (int i = 0; i < 3; i++)
            {
                dep[i].Display();
            }
        }
    }
}
