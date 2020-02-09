using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPillars
{
    public abstract class Figure
    {
        protected float fArea;

        public abstract void CalculateArea();

        public virtual string GetFigureType()
        {
            return "Generic figure";
        }
    }
}
