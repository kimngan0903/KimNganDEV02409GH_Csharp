using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_5
{
    internal interface MultipleInterface
    {
        // Define the IDrivable interface
        public interface IDrivable
        {
            // Method declarations
            void Start();
            void Stop();

            // Property declaration
            bool Started
            {
                get;
            }
        }

        // Define the ISteerable interface
        public interface ISteerable
        {
            // Method
            void TurnLeft();
            void TurnRight();
        }    

        // Define the IMovable interface (derived from IDrivable and ISteerable)
        public interface IMovable : IDrivable, ISteerable
        {
            // Method declarations
            void Acclerate();
            void Brake();
        }
    }
}
