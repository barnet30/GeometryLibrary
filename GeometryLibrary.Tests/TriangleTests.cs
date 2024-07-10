using GeometryLibrary.Abstractions.Models;
using Xunit;

namespace GeometryLibrary.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(-1, 2, 2)]
    [InlineData(2, -1, 2)]
    [InlineData(2, 2, 0)]
    public void Constructor_NegativeOrZeroSides_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
    {
        // act assert
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [Fact]
    public void CalculateArea_ValidSides_ShouldReturnCorrectArea()
    {
        // arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);
        double expectedArea = 6;

        // act
        var actualArea = triangle.Area;

        // assert
        Assert.Equal(expectedArea, actualArea, precision: 5);
    }
    
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(1, 1, 1, false)]
    public void IsRectangular_ShouldReturnCorrectResult(double sideA, double sideB, double sideC, bool expectedResult)
    {
        // arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // act
        var isRectangular = triangle.IsRectangular();

        // assert
        Assert.Equal(expectedResult, isRectangular);
    }
}