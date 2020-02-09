using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Tesla : Vehicle
    {
        private static string carName;

        public Tesla(int displacement, float capacity) : base(carName, displacement, capacity)
        {
            //custom costructor

            carName = "Tesla";

        }

        public override bool StartEngine()
        {
            Console.WriteLine("The car is quietly on");

            return true;

            //we can call the base class where we need to use also the main method
            //return base.StartEngine();
        }
    }
}
