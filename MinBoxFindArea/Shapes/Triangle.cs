using System;
using System.Collections.Generic;
using System.Text;

namespace MinBoxFindArea.Shapes
{
    public class Triangle : Figure
    {
        
        private double _a, _b, _c;
       
        public double A => _a;
        public double B => _b;
        public double C => _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
