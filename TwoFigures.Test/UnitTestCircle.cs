using TwoFigures.Domain;

namespace TwoFigures.Test
{
    public class UnitTestCircle
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5.5)]
        public void Circle_Radius_IsPositive(double radius)
        {
            // Act
            var circle = new Circle(radius);

            // Assert
            Assert.Equal(radius, circle.Radius);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-5.5)]
        public void Circle_Radius_ThrowsArgumentExceptionWhenNegative(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, Math.PI)]
        public void Circle_Area_IsPositive(double radius, double expectedArea)
        {
            // Act
            var circle = new Circle(radius);
            // Assert
            Assert.Equal(expectedArea, circle.Area);
        }

       

        [Theory]
        [InlineData(-1)]
        [InlineData(-5.5)]
        public void CircleArea_ThrowsArgumentException_WhenNegativeRadius(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius).Area);
        }
    }
}