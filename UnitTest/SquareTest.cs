using SOLID_Practice;

namespace UnitTest;

public class SquareTest
{
    [Theory]
    [InlineData(2,3,4)]
    public static void SquareAreaShouldReturnTheAreaOfTheSquare(double sideLength, int decimalPlaces, double expected)
    {
        //Arrange
        Square squareObject = new Square(sideLength, decimalPlaces);
        //Actual
        double result = squareObject.Area();
        //Assert
        
        Assert.Equal(expected,result);
    }
}