using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Vehicle
    {
        protected int wheelsNumber;
        protected string model;
        protected Engine engine;
        protected Tank tank;

        public Vehicle(string mod, int displacement, float capacity)
        {
            model = mod;
            engine = new Engine(displacement);
            tank = new Tank(capacity);

            //free fuel for the tank!
            tank.FillTank(20f);
        }

        public virtual bool StartEngine()
        {
            if(tank.Fuel > 0)
            {
                this.engine.PowerOn();

                return true;
            }
            else
            {
                Console.WriteLine("Tank is empty!");

                return false;
            }
        }
    }
}
