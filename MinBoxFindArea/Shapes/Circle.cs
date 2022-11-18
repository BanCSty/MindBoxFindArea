using System;
using System.Collections.Generic;
using System.Text;

namespace MinBoxFindArea.Shapes
{
    public class Circle : Figure
    {
        public double Radius { get;}
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
