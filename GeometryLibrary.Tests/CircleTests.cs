using GeometryLibrary.Abstractions.Models;
using Xunit;

namespace GeometryLibrary.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void CreatingCircle_WithNegativeRadius_ShouldThrowException(double radius)
    {
        // assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, Math.PI * 4)]
    public void CalculateArea_ShouldReturnValidArea(double radius, double expectedArea)
    {
        // arrange
        var circle = new Circle(radius);
        
        // act 
        var area = circle.Area;
        
        // assert
        Assert.Equal(expectedArea, area, precision: 5);
    }
}