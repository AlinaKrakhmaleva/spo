using System;

namespace GeometricFigures
{
    /// <summary>
    /// Класс "Треугольник"
    /// </summary>
    [Serializable]
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _sideA = value;
            }
        }

        /// <summary>
        /// Сторона В
        /// </summary>
        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _sideB = value;
            }
        }

        /// <summary>
        /// Сторона С
        /// </summary>
        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Значение не может быть нулевым или меньше нуля");
                }
                _sideC = value;
            }
        }

        /// <summary>
        /// Проверка сторон треугольника
        /// </summary>
        public void SetSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными или равными нулю");
            }
            if (((sideA + sideC) <= sideB) || ((sideB + sideC) <= sideA) || ((sideA + sideB) <= sideC))
            {
                throw new ArgumentException("Неверно введены стороны треугольника");
            }
            else
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }

        /// <summary>
        /// Пустой конструктор 
        /// </summary>
        public Triangle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>

        public Triangle(double sideA, double sideB, double sideC)
        {
            SetSides(sideA, sideB, sideC);
        }

        /// <summary>
        /// Получение площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double Area
        {
            get
            {
                if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
                {
                    throw new ArgumentException("Треугольник не инициализирован значениями");
                }
                return Math.Sqrt((Perimeter/2) * ((Perimeter / 2) - SideA) * ((Perimeter / 2) - SideB) * ((Perimeter / 2) - SideC));
            }
        }

        /// <summary>
        /// Получение периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double Perimeter
        {
            get
            {
                if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
                {
                    throw new ArgumentException("Треугольник не инициализирован значениями");
                }
                return (SideA + SideB + SideC);
            }
        }
        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type => "Треугольник";
    }
}

