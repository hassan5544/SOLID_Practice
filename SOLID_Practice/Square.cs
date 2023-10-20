using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice
{
    /// <summary>
    /// Remove the Square Class to its own file
    /// </summary>
    public class Square : IShapes
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            this.SideLength = sideLength;
        }

        public Square()
        {
                
        }

        /// <summary>
        /// Implement the Area function from the IShapes Interface with the Calculation of Area
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return SideLength * SideLength;
        }
    }
}
