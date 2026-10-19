using System.Globalization;
using Course.Model.Entities;

namespace Course.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return $"Circle color: {Color}\n" +
                $"Radius: {Radius.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Circle area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
