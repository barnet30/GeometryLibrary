using GeometryLibrary;
using GeometryLibrary.Abstractions.Models;

var circle = new Circle(2);
var triangle = new Triangle(2, 2, 3);
Console.WriteLine($"Площадь круга = {circle.Area}");
Console.WriteLine($"Площадь треугольника = {triangle.Area}");

var calculatorResult = AreaCalculator.GetArea(circle);
Console.WriteLine($"Площадь круга через калькулятор = {calculatorResult}");

calculatorResult = AreaCalculator.GetArea(triangle);
Console.WriteLine($"Площадь треугольника через калькулятор = {calculatorResult}");


var rectangularTriangle = new Triangle(3, 4, 5);
if (rectangularTriangle.IsRectangular())
    Console.WriteLine("Второй треугольник прямоугольный");
else
    Console.Write("Треугольник не является прямоугльниым");