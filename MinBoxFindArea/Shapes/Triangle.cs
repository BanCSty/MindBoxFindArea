using System;
using System.Linq;

namespace MinBoxFindArea.Shapes
{
    public class Triangle : Figure
    {

        private double _a, _b, _c;

        public double A { get => _a; set => _a = CeckValue(value); }
        public double B { get => _b; set => _b = CeckValue(value); }
        public double C { get => _c; set => _c = CeckValue(value); }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRectengular()
        {
            double max = new double[] { A, B, C }.Max();
            double maxPow = max * max * 2;
            return maxPow == A * A + B * B + C * C;
        }

        public override double GetArea()
        {
            var halfPerimeter = (A + B + C) / 2;

            //Coefficient
            var ACoff = halfPerimeter - A;
            var BCoff = halfPerimeter - B;
            var CCoff = halfPerimeter - C;

            return Math.Sqrt(halfPerimeter * ACoff * BCoff * CCoff);
        }

        public double CeckValue(double value)
        {
            if (value >= 0)
                return value;
            else throw new ArgumentException("Value must be positiv :)");
        }
    }
}
