namespace GeometricFigures
{
    public class Circle : ISquare
    {
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * _radius * _radius;
        }

        private double _radius;
    }
}
