using System;

/*
    Для добавления новой фигуры просто потребуется сделать наслеуемый класс от Figure 
    и реализовать абстрактный метод GetArea.
 */

namespace MinBoxFindArea
{
    public abstract class Figure
    {
        //ленивая инициализация для повышения производительности(ведь далеко не всегда нужен этот функционал)
        //и лаконичности кода
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        protected Figure()
        {
            _area = new Lazy<double>(GetArea);
        }

        //Проверка числа. Служит фильтром для присвоения валидных значений свойствам
        public double CeckNegativeValue(double value)
        {
            if (value >= 0)
                return value;
            else throw new ArgumentException("Value must be positiv :)");
        }

        //Поиск площади
        public abstract double GetArea();
    }
}
