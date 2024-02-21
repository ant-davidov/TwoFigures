using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain;

namespace TwoFigures.Test
{
    public class UnitTestTriangle
    {
        [Fact]
        public void Triangle_Constructor_ThrowsExceptionWhenSidesAreNegative()
        {
            // Arrange
            double a = -1;
            double b = 2;
            double c = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void Triangle_Constructor_ThrowsExceptionWhenTriangleDoesNotExist()
        {
            // Arrange
            double a = 2;
            double b = 1;
            double c = 4;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void Triangle_Constructor_SetsSidesCorrectlyPositive()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            Triangle triangle = new Triangle(a, b, c);

            // Assert
            Assert.Equal(a, triangle.A);
            Assert.Equal(b, triangle.B);
            Assert.Equal(c, triangle.C);
        }

        [Fact]
        public void Triangle_IsExists_ValidTrianglePositive()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            bool exists = Triangle.IsExists(a, b, c);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void Triangle_IsExists_InvalidTriangleNegative()
        {
            // Arrange
            double a = 2;
            double b = 1;
            double c = 4;

            // Act
            bool exists = Triangle.IsExists(a, b, c);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void Triangle_IsRightAngled_ForRightTrianglePositive()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void Triangle_IsRightAngled_ForNonRightTriangleNegative()
        {
            // Arrange
            double a = 6;
            double b = 12;
            double c = 13;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }

        [Fact]
        public void Triangle_Area_CalculatesCorrectly()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            Triangle triangle = new Triangle(a, b, c);
            double area = triangle.Area;

            // Assert 
            double s = (a + b + c) / 2;
            double calculatedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Assert.Equal(calculatedArea, area);
        }
    }
}
