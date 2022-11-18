using System;
using System.Linq;

namespace MinBoxFindArea.Shapes
{
    public class Triangle : Figure
    {

        private double _a, _b, _c;

        public double A { get => _a; set => _a = CeckNegativeValue(value); }
        public double B { get => _b; set => _b = CeckNegativeValue(value); }
        public double C { get => _c; set => _c = CeckNegativeValue(value); }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRectengular()
        {
            double max = new double[] { _a, _b, _c }.Max();
            double maxPow = max * max * 2;
            return maxPow == _a * _a + _b * _b + _c * _c;
        }

        public override double GetArea()
        {
            var halfPerimeter = (_a + _b + _c) / 2;

            //Coefficient
            var ACoff = halfPerimeter - _a;
            var BCoff = halfPerimeter - _b;
            var CCoff = halfPerimeter - _c;

            return Math.Sqrt(halfPerimeter * ACoff * BCoff * CCoff);
        }
    }
}
