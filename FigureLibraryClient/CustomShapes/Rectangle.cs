using FigureLibrary.Abstractions;

namespace FigureLibraryClient.CustomShapes;

public sealed class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentOutOfRangeException("The value cannot be less than or equal to zero");
        }

        Width = width;
        Height = height;
    }
    
    public double CalculateArea()
    {
        return Width * Height;
    }
}