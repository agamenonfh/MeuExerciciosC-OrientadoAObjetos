using Course.Model.Entities;
using System.Globalization;

namespace Course.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
        public override string ToString()
        {
            return $"Rectangle color: {Color}\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}\n" +
                $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
