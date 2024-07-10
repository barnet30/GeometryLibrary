using GeometryLibrary.Abstractions.Interfaces;

namespace GeometryLibrary.Abstractions.Models;

public class Circle : IFigure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero");
        
        Radius = radius;
    }
    
    public double Area => Math.PI * Radius * Radius;
}