using System;

namespace GeometricFigures
{

    /// <summary>
    /// Класс "Окружность"
    /// </summary>
   
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус Окружности
        /// </summary>
        private double _radius;

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Пустой конструктор окружности.
        /// </summary>
        public Circle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Площадь окружности
        /// </summary>
        public double Area
        {
            get
            {
                if (_radius <= 0)
                {
                    throw new ArgumentException("Нет данных");
                }
                return (Math.PI*Radius*Radius);
            }
        }

        /// <summary>
        /// Периметр окружности
        /// </summary>
        public double Perimeter
        {
            get
            {
                if (_radius <= 0)
                {
                    throw new ArgumentException("Нет данных");
                }
                return (2*Math.PI*Radius);
            }
        }
        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type => "Окружность";
    }
}
    