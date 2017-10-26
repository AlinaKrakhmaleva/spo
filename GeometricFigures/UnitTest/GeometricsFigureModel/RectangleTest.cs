using System;
using NUnit.Framework;
using GeometricFigures;

namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        [TestCase(4.4, 
            TestName = "Тестирование свойства Width при присваивании значения с дробной частью")]
        [TestCase(4, 
            TestName = "Тестирование свойства Width при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства Width при присваивании нулевого значения")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства Width при присваивании отрицательного значения")]
        public void WidthTest(double width)
        {
            var rectangle = new Rectangle();
            rectangle.Width = width;
        }

        [Test]
        [TestCase(4.4, 
            TestName = "Тестирование свойства Height при присваивании значения с дробной частью")]
        [TestCase(4, 
            TestName = "Тестирование свойства Height при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства Height при присваивании нулевого значения")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства Height при присваивании отрицательного значения")]
        public void HeightTest(double height)
        {
            var rectangle = new Rectangle();
            rectangle.Height = height;
        }

        [Test]
        [TestCase(4, 4, ExpectedResult = 16, 
            TestName = "Тестирование класса Rectangle свойства Area при верном значении")]
        [TestCase(-4, 4, ExpectedException = (typeof(ArgumentException)), 
            TestName = "Тестирование класса Rectangle свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(5, 8, ExpectedResult = 40, 
            TestName = "Тестирование класса Rectangle свойства Area при верном значении")]
        [TestCase(5, -8, ExpectedException = (typeof(ArgumentException)), 
            TestName = "Тестирование класса Rectangle свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(5, 1, ExpectedResult = 5, 
            TestName = "Тестирование класса Rectangle свойства Area при верном значении")]
        public double RectangleAreaTest(double height, double width)
        {
            var rectangle = new Rectangle(height, width);
            return rectangle.Area;
        }

        [Test]
        [TestCase(4, 4, ExpectedResult = 16, 
            TestName = "Тестирование класса Rectangle свойства Perimeter при верном значении")]
        [TestCase(-4, 4, ExpectedException = (typeof(ArgumentException)), 
            TestName = "Тестирование класса Rectangle свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(3, 5, ExpectedResult = 16, 
            TestName = "Тестирование класса Rectangle свойства Perimeter при верном значении")]
        [TestCase(-3, -5, ExpectedException = (typeof(ArgumentException)),    
            TestName = "Тестирование класса Rectangle свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(1, 4, ExpectedResult = 10, 
            TestName = "Тестирование класса Rectangle свойства Perimeter при верном значении")]
        public double RectanglePerimeterTest(double height, double width)
        {
            var rectangle = new Rectangle(height, width);
            return rectangle.Perimeter;
        }

    }
}