namespace GeometricFigures
{
    public class Circle : ISquare
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("radius cannot be less than or equal to zero");

            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * _radius * _radius;
        }

        private double _radius;
    }
}
