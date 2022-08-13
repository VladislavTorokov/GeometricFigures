namespace GeometricFigures
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double? firstCathetus, double? secondCathetus)
        {
            if (firstCathetus == null || secondCathetus == null)
                throw new ArgumentException("both cathetuses must have values");

            _firstCathetus = firstCathetus.Value;
            _secondCathetus = secondCathetus.Value;
        }

        public override double CalculateSquare()
        {
            return _firstCathetus * _secondCathetus / 2.0;
        }

        private double _firstCathetus;
        private double _secondCathetus;
    }
}
