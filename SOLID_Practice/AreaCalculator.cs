using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice
{
    public class AreaCalculator
    {
        public double CalulateAreaOfShape(IShapes shape)
        {
            return shape.Area();

        }
    }
}
