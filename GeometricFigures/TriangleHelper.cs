namespace GeometricFigures
{
    public static class TriangleHelper
    {
        /// <summary>
        /// Sides are opposite angles,
        /// For example: side A is opposite angle A
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="angleA"></param>
        /// <param name="angleB"></param>
        /// <param name="angleC"></param>
        /// <returns></returns>
        public static Triangle TriangleBySidesAndAngles(double? sideA = null, double? sideB = null, double? sideC = null, 
            double? angleA = null, double? angleB = null, double? angleC = null)
        {
            var sides = new[] { sideA, sideB, sideC };
            var angles = new [] { angleA, angleB, angleC };

            var rightAngleIndex = RightAngleIndex(angles);
            if (rightAngleIndex != -1)
            {
                var cathetuses = AdjacentSidesOfAngle(sides, rightAngleIndex);

                return new RightTriangle(cathetuses.fisrtCathetus, cathetuses.secondCathetus);
            }

            return new ArbitraryTriangle(sides);
        }

        /// <summary>
        /// Get adjacent sides of an angle
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="rightAngleIndex"></param>
        /// <returns></returns>
        private static (double? fisrtCathetus, double? secondCathetus) AdjacentSidesOfAngle(double?[] sides, int rightAngleIndex)
        {
            int secondCathetusIndex;
            int firstCathetusIndex;
            if (rightAngleIndex == 0)
            {
                firstCathetusIndex = sides.Length - 1;
                secondCathetusIndex = rightAngleIndex + 1;
            }
            else if (rightAngleIndex == sides.Length - 1)
            {
                firstCathetusIndex = rightAngleIndex - 1;
                secondCathetusIndex = 0;
            }
            else
            {
                firstCathetusIndex = rightAngleIndex - 1;
                secondCathetusIndex = rightAngleIndex + 1;
            }

            return (sides[firstCathetusIndex], sides[secondCathetusIndex]);
        }

        /// <summary>
        /// Finding right angle index, if not exist return -1
        /// </summary>
        /// <param name="angles"></param>
        /// <returns></returns>
        private static int RightAngleIndex(double?[] angles)
        {
            const double rightAngle = 90;
            for (var i = 0; i < angles.Length; i++)
            {
                var angle = angles[i];

                if (angle == null)
                    continue;

                if (Math.Abs(rightAngle - angle.Value) < 10E-4)
                {
                     return i;
                }
            }

            return -1;
        }
    }
}
