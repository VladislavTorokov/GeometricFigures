namespace GeometricFigures
{
    public class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle(double[] sides) : this(sides.Cast<double?>().ToArray())
        {
        }

        public ArbitraryTriangle(double?[] sides)
        {
            const int maxSideCount = 3;
            if (sides.Length < maxSideCount || sides.Any(side => side == null))
                throw new ArgumentException("The number of sides must be at least 3");

            _sides = new double[maxSideCount];

            _sides[0] = sides[0].Value;
            _sides[1] = sides[1].Value;
            _sides[2] = sides[2].Value;

            _halfPerimeter = _sides.Sum() / 2.0;
            if (_sides.Any(side => side >= _halfPerimeter))
                throw new ArgumentException("side cannot be more than half a perimeter");

        }

        /// <summary>
        /// by Heron's formula
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            return Math.Sqrt(_halfPerimeter *
                (_halfPerimeter - _sides[0]) *
                (_halfPerimeter - _sides[1]) *
                (_halfPerimeter - _sides[2]));
        }

        private double[] _sides;
        private double _halfPerimeter;
    }
}
