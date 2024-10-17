using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab04_5.MultipleInterface;

namespace Lab04_5
{
    public class Car : MultipleInterface
    {
        // Declare the underlying field used by the
        // Started property of the IDrivable interface
        private bool started = false;

        // Implement the Start() method of the IDrivable interface
        public void Start()
        {
            Console.WriteLine("Car started");
            started = true;
        }

        // Implement the Stop() method of the IDrivable interface
        public void Stop()
        {
            Console.WriteLine("Car stopped");
            started = false;
        }

        // Implement the Started property of the IDrivable interface
        public bool Started
        {
            get
            {
                return started;
            }
        }

        // Implement the TurnLeft() method of the ISteerable interface
        public void TurnLeft()
        {
            Console.WriteLine("Car turning left");
        }

        // Implement the TurnRight() method of the ISteerable interface
        public void TurnRight()
        {
            Console.WriteLine("Car turning right");
        }

        // Implement the Accelerate() method of the IMovable interface
        public void Accelerate()
        {
            Console.WriteLine("Car accelerating");
        }

        // Implement the Brake() method of the IMovable interface
        public void Brake()
        {
            Console.WriteLine("Car braking");
        }
    }
}
