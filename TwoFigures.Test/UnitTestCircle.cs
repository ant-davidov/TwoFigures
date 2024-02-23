using TwoFigures.Domain;

namespace TwoFigures.Test
{
    public class UnitTestCircle
    {
        [Theory]
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
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5.5)]
        public void Circle_Radius_ThrowsArgumentExceptionWhenNegative(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        public void Circle_Area_IsPositive(double radius, double expectedArea)
        {
            // Act
            var circle = new Circle(radius);
            // Assert
            Assert.Equal(expectedArea, circle.Area);
        }

        [Theory]
        [InlineData(-231.21313231)]
        [InlineData(-1)]
        [InlineData(-5.5)]
        public void CircleArea_ThrowsArgumentException_WhenNegativeRadiusNegative(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius).Area);
        }

        [Theory]
        [InlineData(double.Epsilon)]
        [InlineData(double.Epsilon * 10)]
        [InlineData(double.Epsilon * Int16.MaxValue)]
        public void CircleArea_ThrowsArgumentException_WhenRadiusSoSmallNegative(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius).Area);
        }

        [Theory]
        [InlineData(double.MaxValue - Int16.MaxValue)]
        public void CircleArea_ThrowsArgumentException_WhenRadiusSoLargeNegative(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius).Area);
        }
    }
}