using GeometryLibrary.Abstractions.Interfaces;

namespace GeometryLibrary;

public static class AreaCalculator
{
    public static double GetArea(IFigure figure) => figure.Area;
}