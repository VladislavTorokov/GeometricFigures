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
            var arbitraryTriangle = new ArbitraryTriangle(new double[] { 6, 8, 10 });
            var rightTriangle = new RightTriangle(10, 12);

            var expectedSquares = new double[] { radius * radius * Math.PI, 24, 60 };

            var geometricFigures = new ISquare[] { circle, arbitraryTriangle, rightTriangle };
            for (int i = 0; i < geometricFigures.Length; i++)
            {
                Assert.AreEqual(expectedSquares[i] ,geometricFigures[i].CalculateSquare());
            }
        }
    }
}
