using TwoFigures.Domain;
using TwoFigures.Domain.AbstractClass;
using TwoFigures.Domain.Interfaces;

AbstractFigure[] figures =
    {
      new Triangle(3, 4, 5),
      new Circle(4)
    };

foreach (var fig in figures)
    Console.WriteLine($"Площадь фигуры   = {fig.Area}");

var triangle = new Triangle(3, 4, 5);

if (triangle.IsRightAngled())
    Console.WriteLine("Треугольник прямоугольный");