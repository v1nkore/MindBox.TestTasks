using FigureLibrary.Abstractions;

namespace FigureLibrary.Shapes
{
	public class Triangle : IShape
	{
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }
		public bool Right { get; }
		

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
			{
				throw new ArgumentOutOfRangeException("Sides must be greater than zero");
			}
			
			if (sideA + sideB <= sideC
			    || sideB + sideC <= sideA
			    || sideC + sideA <= sideB)
			{
				throw new ArgumentException("One side of a triangle is greater than the sum of the other two sides. " +
				                            "Such a triangle cannot exist.");
			}

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
			Right = IsRight();
		}

		public double CalculateArea()
		{
			var perimeter = (SideA + SideB + SideC) / 2;

			return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
		}

		public bool IsRight()
		{
			return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
		}
	}
}
