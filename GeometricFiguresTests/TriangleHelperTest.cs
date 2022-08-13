using NUnit.Framework;
using GeometricFigures;
using System;

namespace GeometricFiguresTests
{
    public class TriangleHelperTest
    {
        [Test]
        public void SquareTest()
        {
            var arbitraryTriangle = TriangleHelper.TriangleBySidesAndAngles(6, 8, 10);
            var rightTriangle = TriangleHelper.TriangleBySidesAndAngles(null, 10, 12, 90);

            var expectedSquares = new double[] { 24, 60 };

            var geometricFigures = new ISquare[] { arbitraryTriangle, rightTriangle };
            for (int i = 0; i < geometricFigures.Length; i++)
            {
                Assert.AreEqual(expectedSquares[i], geometricFigures[i].CalculateSquare());
            }
        }

        [Test]
        public void InvalidSquareTest()
        {
            Assert.Throws<ArgumentException>(() => TriangleHelper.TriangleBySidesAndAngles(1, 2, 3));
            Assert.Throws<ArgumentException>(() => TriangleHelper.TriangleBySidesAndAngles(6, 8, null));
            Assert.Throws<ArgumentException>(() => TriangleHelper.TriangleBySidesAndAngles(null, null, null, 90));
            Assert.Throws<ArgumentException>(() => TriangleHelper.TriangleBySidesAndAngles(12, 10, null, 43, 90));
        }
    }
}
