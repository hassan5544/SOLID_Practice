using System;
using SOLID_Practice;

class SmellyCodeExample
{
    static void Main(string[] args)
    {
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
            double circleArea =shapes[choice].Area();
            Console.WriteLine("The area of the circle is: " + circleArea);
        }

        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

