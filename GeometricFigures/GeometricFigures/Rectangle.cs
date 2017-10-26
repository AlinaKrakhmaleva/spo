using System;

namespace GeometricFigures
{
    /// <summary>
    /// Класс "Прямоугольник" 
    /// </summary>
    [Serializable]
    public class Rectangle : IFigure
    {
        private double _height;
        private double _width;

        /// <summary>
        ///  Инициализация высоты прямоугольника.
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Инициализация ширины прямоугольника.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _width = value;
            }
        }

        /// <summary>
        /// Пустой конструктор прямоугольника
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// конструктор прямоугольника
        /// </summary>
        public Rectangle(double height, double width)
        {

            Height = height;
            Width = width;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        public double Area
        {
            get
            {
                if (_height <= 0 || _width <= 0)
                {
                    throw new ArgumentException("Прямоугольник не инициализирован значениями");
                }
                return (Height * Width);
            }
        }

        /// <summary>
        /// Периметр прямоугльника
        /// </summary>
        public double Perimeter
        {
            get
            {
                if (_height <= 0 || _width <= 0)
                {
                    throw new ArgumentException("Прямоугольник не инициализирован значениями");
                }
                return ((Height + Width) * 2);
            }
        }
        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type => "Прямоугольник";
    }
}
