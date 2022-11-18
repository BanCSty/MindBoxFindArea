using System;

namespace MinBoxFindArea
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        protected Figure()
        {
            _area = new Lazy<double>(GetArea);
        }

        public abstract double GetArea();
    }
}
