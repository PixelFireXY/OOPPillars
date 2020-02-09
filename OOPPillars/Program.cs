using System;

namespace OOPPillars
{
    class Program
    {
        static void Main(string[] args)
        {
            //With the ENCAPSULATION, when we instantiate the class Vehicle, we don't need to know how it works, we just call what we need to have a clean interface to work with (Information hiding)
            Vehicle vehicle = new Vehicle(4, "Tesla", 1024, 50);

            vehicle.StartEngine();

            Console.ReadLine();
        }
    }
}
