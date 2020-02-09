using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    class Cube : Figure
    {
        float side;

        public override void CalculateArea()
        {
            fArea = side * side;
        }

        public override string GetFigureType()
        {
            return "Cube";
        }
    }
}
