using System;

/*
    Для добавления новой фигуры просто потребуется сделать наслеуемый класс от Figure 
    и реализовать абстрактный метод GetArea.
 */

namespace MinBoxFindArea
{
    public abstract class Figure
    {
        //ленивая реализация для повышения производительности(ведь далеко не всегда нужен этот функционал)
        //и лаконичности кода
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        protected Figure()
        {
            _area = new Lazy<double>(GetArea);
        }

        //Возможно спроное решение, однако предотвращает повторение кода
        public double CeckNegativeValue(double value)
        {
            if (value >= 0)
                return value;
            else throw new ArgumentException("Value must be positiv :)");
        }

        public abstract double GetArea();
    }
}
