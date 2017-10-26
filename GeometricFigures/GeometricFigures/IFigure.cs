using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IFigure 
    {
        /// <summary>
        /// Получение площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double Area { get; }

        /// <summary>
        /// Получение периметра фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        double Perimeter { get; }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        string Type { get; }
    }
}
