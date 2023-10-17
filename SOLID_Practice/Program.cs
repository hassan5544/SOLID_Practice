using System;

class SmellyCodeExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a shape:\n1. Circle\n2. Square");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle();
            double circleArea = circle.CalculateCircleArea(radius);
            Console.WriteLine("The area of the circle is: " + circleArea);
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter the side length of the square:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            Square square = new Square();
            double squareArea = square.CalculateSquareArea(sideLength);
            Console.WriteLine("The area of the square is: " + squareArea);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

class Circle
{
    public double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

class Square
{
    public double CalculateSquareArea(double sideLength)
    {
        return sideLength * sideLength;
    }
}