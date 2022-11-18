using System;

namespace MinBoxFindArea.Shapes
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius { get => _radius; set => _radius = CeckNegativeValue(value); }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Radius * Radius * Math.PI;

    }
}
