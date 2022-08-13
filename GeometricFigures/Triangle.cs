namespace GeometricFigures
{
    public class Triangle : ISquare
    {
        public bool IsRightTriangle { get; set; } = false;

        public Triangle(double[] sides)
        {
            const int maxSideCount = 3;
            if (sides.Length != maxSideCount)
                throw new ArgumentException("The number of sides must be 3");

            _sides = new double[maxSideCount];

            _sides[0] = sides[0];
            _sides[1] = sides[1];
            _sides[2] = sides[2];

            _halfPerimeter = _sides.Sum() / 2.0;
            if (_sides.Any(side => side >= _halfPerimeter))
                throw new ArgumentException("side cannot be more than half a perimeter");

            IsRightTriangle = CheckRightAngle();
        }

        /// <summary>
        /// by Heron's formula
        /// </summary>
        /// <returns></returns>
        public double CalculateSquare()
        {
            return Math.Sqrt(_halfPerimeter * 
                (_halfPerimeter - _sides[0]) * 
                (_halfPerimeter - _sides[1]) * 
                (_halfPerimeter - _sides[2]));
        }

        private bool CheckRightAngle()
        {
            var hypotenuse = _sides.Max();
            var cathetuses = _sides.Where(side => side < hypotenuse);
            var firstCathetus = cathetuses.First();
            var secondCathetus = cathetuses.Last();

            return Math.Abs((hypotenuse * hypotenuse) - (firstCathetus * firstCathetus + secondCathetus * secondCathetus)) < 10E-4;
        }

        private double[] _sides;
        private double _halfPerimeter;
    }
}
