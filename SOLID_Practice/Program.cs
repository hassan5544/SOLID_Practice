using System;
using System.Reflection;
using SOLID_Practice;

class SmellyCodeExample
{
    
    ConverterFunc<string, int> intToStringConverter = Convert.ToInt32;


    static void Main(string[] args)
    {
        List<IShapes> shapes = InterfaceFactory.CreateListOfShapes();
        UserInterActions.ShowOutput("Choose a shape:\n");
        for (int item = 0; item < shapes.Count; item++)
        {
            UserInterActions.ShowOutput(item.ToString() + "." + shapes[item].GetType().Name.ToString() + "\n");
        }


        int choice = UserInterActions.GetInput();

        if (choice < shapes.Count)
        {
            UserInterActions.ShowOutput("Enter the Parameters of the " + shapes[choice].GetType().Name);
            double parameters = Convert.ToDouble(Console.ReadLine());
            shapes[choice] =  InterfaceFactory.CreateInstance(shapes[choice].GetType() , parameters);
            double AreaOfShape = shapes[choice].Area();
            UserInterActions.ShowOutput("The area of the circle is: " + AreaOfShape);
        }

        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

