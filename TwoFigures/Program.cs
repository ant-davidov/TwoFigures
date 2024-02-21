using TwoFigures.Domain;
using TwoFigures.Domain.Interfaces;

IFigure[] figures =
    {
      new Triangle(3, 4, 5),
      new Circle(4)
    };

foreach (var fig in figures)
    Console.WriteLine($"Площадь фигуры   = {fig.Area}");

var triangle = new Triangle(3, 4, 5);

if (triangle.IsRightAngled())
    Console.WriteLine("Треугольник прямоугольный");