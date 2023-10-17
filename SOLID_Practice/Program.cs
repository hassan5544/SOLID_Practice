using System;
using SOLID_Practice;

class SmellyCodeExample
{
    static void Main(string[] args)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        List<IShapes> shapes = new List<IShapes> {
            new Circle(0) , 
            new Square(0)
        };
        Console.WriteLine("Choose a shape:\n");
        for (int item = 0; item < shapes.Count ; item ++ )
        {
            Console.WriteLine((item + 1).ToString() + "." + shapes[item].GetType().Name.ToString() + "\n");
        }
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice < shapes.Count)
        {
            Console.WriteLine("Enter the Parameters of the " + shapes[choice].GetType().Name);
            double parameters = Convert.ToDouble(Console.ReadLine());
            object test = shapes[choice];
            shapes[choice].Equals(parameters);
            double circleArea = areaCalculator.CalulateAreaOfShape(shapes[choice]);
            Console.WriteLine("The area of the circle is: " + circleArea);
        }

        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

//class Circle
//{
//    public double CalculateCircleArea(double radius)
//    {
//        return Math.PI * radius * radius;
//    }
//}

//class Square
//{
//    public double CalculateSquareArea(double sideLength)
//    {
//        return sideLength * sideLength;
//    }
//}