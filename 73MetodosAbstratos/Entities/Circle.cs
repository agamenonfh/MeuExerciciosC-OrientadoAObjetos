using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Circle : Shape
    {
        public double Radiu { get; set; }
        public Circle(double radiu,Color color) : base(color)
        {
            Radiu = radiu;
        }
        public override double Area()
        {
            return Math.PI * (Radiu * Radiu);
        }
    }
}
