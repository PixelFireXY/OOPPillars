using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Tank
    {
        private float fuel;

        public float Capacity { get; private set; }
        public float Fuel
        {
            get { return fuel; }
            private set
            {
                if (fuel + value > Capacity)
                    fuel = Capacity;
                else
                    fuel += value;
            }
        }

        public Tank(float cap)
        {
            Capacity = cap;
            Fuel = 0f;
        }

        public void FillTank(float fuelAmount)
        {
            Fuel = fuelAmount;
        }
    }
}
