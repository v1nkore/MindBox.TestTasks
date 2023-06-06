using FigureLibrary.Abstractions;

namespace FigureLibrary.Shapes
{
    public class Circle : IShape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be greater than zero");
            }

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
