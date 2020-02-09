using System;

namespace OOPPillars
{
    class Program
    {
        static void Main(string[] args)
        {
            //With the ENCAPSULATION, when we instantiate the class Vehicle, we don't need to know how it works, we just call what we need to have a clean interface to work with (Information hiding)
            Vehicle vehicle = new Vehicle("Toyota", 125, 5);

            vehicle.StartEngine();

            Console.ReadLine();


            //With the INHERITANCE you can create a new car, base on vehicle class that get all properties of the main class with his custom properties
            Car car = new Car("BMW", 2000, 50, 5);

            car.StartEngine();

            Console.ReadLine();

            //With the POLYMORPHISM you can override the base method to create custom behaviour for each class
            Tesla tesla = new Tesla(5000, 50);

            tesla.StartEngine();

            Console.ReadLine();
        }
    }
}
