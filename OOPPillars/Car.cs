using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; private set; }

        public Car(string mod, int displacement, float capacity, int doorsNumb) : base(mod, displacement, capacity)
        {
            wheelsNumber = 4;
            NumberOfDoors = doorsNumb;
        }

        public void SomeCarBehaviour()
        {
            //do car stuff
        }
    }
}
