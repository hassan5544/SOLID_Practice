using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice
{
    /// <summary>
    /// Remove the Circle Class from the programe.cs to its own class file
    /// </summary>
    public class Circle : IShapes
    {
        public double Radius { get; set; }
        public int DecimalPlaces { get; set; }
        public Circle(double radius,int decimalPlaces)
        {
            this.Radius = radius;
            this.DecimalPlaces = decimalPlaces;
        }
        
        /// <summary>
        /// Implement the Area function from the IShapes Interface with the Calculation of Area
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Math.Round(Math.PI * Radius * Radius , DecimalPlaces);
        }
    }
}
