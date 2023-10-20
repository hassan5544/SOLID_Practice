using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice
{
    public class InterfaceFactory
    {
        public static List<IShapes> CreateListOfShapes()
        {
            return new List<IShapes> {
                new Circle() ,
                new Square()
            };
        }
        public static IShapes CreateInstance(Type type, params object[] args)
        {

            ConstructorInfo constructor = type.GetConstructor(args.Select(arg => arg.GetType()).ToArray());

            if (constructor == null)
            {
                throw new ArgumentException("Class does not have a default constructor.");
            }

            return (IShapes)constructor.Invoke(args);


            throw new ArgumentException("Invalid class name or class does not implement IShapes");
        }
    }
}
