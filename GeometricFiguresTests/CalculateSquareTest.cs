using NUnit.Framework;
using GeometricFigures;
using System;

namespace GeometricFiguresTests
{
    public class CalculateSquareTest
    {
        [Test]
        public void SquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var triangle = new Triangle(new double[] { 6, 8, 10 });

            var expectedSquares = new double[] { radius * radius * Math.PI, 24};

            var geometricFigures = new ISquare[] { circle, triangle};
            for (int i = 0; i < geometricFigures.Length; i++)
            {
                Assert.AreEqual(expectedSquares[i] ,geometricFigures[i].CalculateSquare());
            }
        }

        [Test]
        public void IsRightTriangleTest()
        {
            var triangle = new Triangle(new double[] { 3, 4, 5 });
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [Test]
        public void InvalidTriangleParameters()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 1, 2, 3 }));
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 10, 12, 13, 14 }));
        }

        [Test]
        public void InvalidCircleParameter()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-10));
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}
