using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Vehicle
    {
        private int wheelsNumber;
        private string model;
        private Engine engine;
        private Tank tank;

        public Vehicle(int wheels, string mod, int displacement, float capacity)
        {
            wheelsNumber = wheels;
            model = mod;
            engine = new Engine(displacement);
            tank = new Tank(capacity);
        }

        public bool StartEngine()
        {
            if(tank.Fuel > 0)
            {
                this.engine.PowerOn();

                return true;
            }
            else
            {
                Console.WriteLine("Tank is empty!");

                tank.FillTank(20f);

                return false;
            }
        }
    }
}
