using FigureLibrary.Shapes;

namespace FigureLibrary.UnitTests
{
    public class FigureLibraryTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-7)]
        public void CalculateCircleArea_ShouldThrowsException_WhenRadiusNegativeOrZero(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var circle = new Circle(radius);
                circle.CalculateArea();
            });
        }

        [Theory]
        [InlineData(5)]
        public void CalculateCircleArea_ShouldReturnArea_WhenRadiusValid(double radius)
        {
            Assert.Equal(expected: 78, (int)new Circle(radius).CalculateArea());
        }

        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, -3)]
        [InlineData(-5, -5, -5)]
        public void CalculateTriangleArea_ShouldThrowsException_WhenArgsNegativeOrZero(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var triangle = new Triangle(sideA, sideB, sideC);
                triangle.CalculateArea();
            });
        }

        [Theory]
        [InlineData(5, 4, 3)]
        public void CalculateTriangleArea_ShouldReturnArea_WhenArgsValid(double sideA, double sideB, double sideC)
        {
            Assert.Equal(expected: 6, (new Triangle(sideA, sideB, sideC).CalculateArea()));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void IsTriangleRight_ShouldReturnTrue_WhenValuesSuitable(double sideA, double sideB, double sideC)
        {
            Assert.True(new Triangle(sideA, sideB, sideC).IsRight());
        }

        [Theory]
        [InlineData(4, 5, 6)]
        [InlineData(4.5, 5.6, 6.4)]
        [InlineData(9, 10, 15)]
        public void IsTriangleRight_ShouldReturnFalse_WhenValuesNotSuitable(double sideA, double sideB, double sideC)
        {
            Assert.False(new Triangle(sideA, sideB, sideC).IsRight());
        }
    }
}