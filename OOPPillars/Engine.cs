using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Engine
    {
        private int displacement;

        public Engine(int cc)
        {
            displacement = cc;
        }

        public void PowerOn()
        {
            Console.WriteLine("Wrooom!");
        }
    }
}
