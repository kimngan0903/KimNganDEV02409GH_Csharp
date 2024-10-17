using System.Security.Cryptography.X509Certificates;

namespace Lab04_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Car object
            Car myCar = new Car();

            // Call myCar.Start()
            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();

            // Call myCar.TurnLeft()
            Console.WriteLine("Calling myCar.TurnLeft()");
            myCar.TurnLeft();

            // Call myCar.Accelerate() 
            Console.WriteLine("Calling myCar.Accelerate()");
            myCar.Accelerate();
            Console.ReadLine();

        }
    }
}
