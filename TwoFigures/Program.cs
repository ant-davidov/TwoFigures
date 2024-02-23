using TwoFigures.Domain;
using TwoFigures.Domain.AbstractClass;

AbstractFigure[] figures =
    {
      new Triangle(3, 4, 5),
      new Circle(4)
    };

foreach (var fig in figures)
    Console.WriteLine($"Площадь фигуры = {fig.Area}");

var triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Треугольник прямоугольный - {triangle.IsRectangular}");