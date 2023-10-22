namespace SOLID_Practice
{
    /// <summary>
    /// Remove the Square Class to its own file
    /// </summary>
    public class Square : IShapes
    {
        public double SideLength { get; set; }
        public int DecimalPlaces { get; set; }
        public Square(double sideLength , int decimalPlaces)
        {
            this.SideLength = sideLength;
            this.DecimalPlaces = decimalPlaces;
        }
        /// <summary>
        /// Implement the Area function from the IShapes Interface with the Calculation of Area
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Math.Round(SideLength * SideLength,DecimalPlaces);
        }
    }
}
