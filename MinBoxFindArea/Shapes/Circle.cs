using System;

namespace MinBoxFindArea.Shapes
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Value must be positiv :)");
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
