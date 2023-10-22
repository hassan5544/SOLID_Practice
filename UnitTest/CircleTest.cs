using SOLID_Practice;
namespace UnitTest;

public class CircleTest
{
    [Theory]
    [InlineData(1, 2 ,3.14)]
    public static void CircleAreaShouldReturnTheAreaOfCircle(double radius , int decimalPlaces, double expected)
    {
        // Arrange
        Circle testCricle = new Circle(radius , decimalPlaces);
        // Actual
        double result = testCricle.Area();
        
        // Assert
        Assert.Equal(expected, result);
    }
}