using FigureLibrary.Abstractions;

namespace FigureLibrary;

public sealed class AreaCalculator
{
    public double Calculate(IShape shape)
    {
        return shape.CalculateArea();
    }   
}