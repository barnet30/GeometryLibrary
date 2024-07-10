using GeometryLibrary.Abstractions.Interfaces;

namespace GeometryLibrary.Abstractions.Models;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Triangle sides must greater than zero");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The provided sides are not valid.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double Area
    {
        get
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }

    public bool IsRectangular()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);

        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) <= Constants.Eps;
    }
}