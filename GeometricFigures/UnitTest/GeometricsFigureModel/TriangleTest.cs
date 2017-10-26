using System;
using GeometricFigures;
using NUnit.Framework;


namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(4.4, 5.67, 4.55, 
            TestName = "Тестирование метода присваивания значений сторон треугольника")]
        [TestCase(-4.4, 5.67, 4.55, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование метода присваивания значений сторон треугольника с отрицательным значением одной из сторон")]
        [TestCase(int.MaxValue, 5.67, 4.55, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование метода присваивания значений сторон треугольника со стороной, значение которой выходит за пределы области допустимых значений")]
        [TestCase(4.4, 5.67, 20.95, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование метода присваивания значений сторон треугольника со стороной, значение которой больше суммы двух других сторон")]
        public void TriangleSetSidsTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            triangle.SetSides(sideA, sideB, sideC);
        }

        [Test]
        [TestCase(4.4, 
            TestName = "Тестирование свойства SideA при присваивании значения с дробной частью")]
        [TestCase(4, 
            TestName = "Тестирование свойства SideA при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideA при присваивании нулевого значения")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideA при присваивании отрицательного значения")]
        public void SideATest(double sideA)
        {
            var triangle = new Triangle();
            triangle.SideA = sideA;
        }

        [Test]
        [TestCase(4.4, 
            TestName = "Тестирование свойства SideB при присваивании значения с дробной частью")]
        [TestCase(4, 
            TestName = "Тестирование свойства SideB при присваивании целого числа")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideB при присваивании нулевого значения")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideB при присваивании отрицательного значения")]
        public void SideBTest(double sideB)
        {
            var triangle = new Triangle();
            triangle.SideB = sideB;
        }

        [Test]
        [TestCase(4.4, 
            TestName = "Тестирование свойства SideC при присваивании первой стороне треугольника значения с дробной частью")]
        [TestCase(4, 
            TestName = "Тестирование свойства SideC при присваивании значения с дробной частью")]
        [TestCase(null, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideС при присваивании нулевого значения")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование свойства SideС при присваивании отрицательного значения")]
        public void SideCTest(double sideC)
        {
            var triangle = new Triangle();
            triangle.SideC = sideC;
        }

        [Test]
        [TestCase(3, 4, 5, ExpectedResult = 6,
            TestName = "2.1) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(6, 8, -1, ExpectedException = typeof(ArgumentException),
            TestName = "2.2) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(6, 8, int.MaxValue, ExpectedException = typeof(ArgumentException),
            TestName = "2.3) Тестирование класса Triangle при присвоении стороне значения, находящегося за пределами допустимых значений")]
        [TestCase(11, 15, 81, ExpectedException = typeof(ArgumentException),
            TestName = "2.4) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, несуществующий треугольник")]
        [TestCase(10, 10, null, ExpectedException = typeof(ArgumentException),
            TestName = "2.5) Тестирование класса Triangle при присвоении стороне нулевого значения")]
        public double TriangleAreaTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.Area;
        }

        [Test]
        [TestCase(1, 2, 2, ExpectedResult = 5,
            TestName = "3.1) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(1, -2, 3, ExpectedException = typeof(ArgumentException),
            TestName = "3.2) Тестирование класса Triangle при присвоении сторон при ошибочных значениях, отрицательное значение")]
        [TestCase(4, 4, 6, ExpectedResult = 14,
            TestName = "3.3) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        [TestCase(11, 15, 81, ExpectedException = typeof(ArgumentException),
            TestName = "3.4)Тестирование класса Triangle при присвоении сторон при ошибочных значениях, несуществующий треугольник")]
        [TestCase(8, 8, 5, ExpectedResult = 21,
            TestName = "3.5) Тестирование класса Triangle при присвоении сторон с верными значениями")]
        public double TrianglePerimeterTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.Perimeter;
        }
    }
}
