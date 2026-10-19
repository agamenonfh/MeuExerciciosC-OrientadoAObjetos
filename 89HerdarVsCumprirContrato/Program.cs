using System;
using System.Globalization;
using Course.Model.Entities;
using Course.Model.Enums;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program test for shape and color of geometric forms");
            Console.Write("Enter the format (Circle(c) or Rectangle(r)): ");
            char sh = char.Parse(Console.ReadLine());
            if (sh == 'c')
            {
                Console.Write("How much is the radius of this circle: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("This circle is black(b) or white(w): ");
                char clr = char.Parse(Console.ReadLine());
                string color = null;
                if (clr == 'b')
                {
                    Shape circle = new Circle() { Color = Color.Black, Radius = radius};
                    Console.WriteLine(circle);
                }
                else if (clr == 'w')
                {
                    Shape circle = new Circle() { Color = Color.White, Radius = radius};
                    Console.WriteLine(circle);
                }
            }
            else if (sh == 'r')
            {
                Console.Write("How much is the height of this rectangle: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("How much is the width of this rectangle: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("This rectangle is black(b) or white(w): ");
                char clr = char.Parse(Console.ReadLine());
                string color = null;
                if (clr == 'b')
                {
                    Shape rectangle = new Rectangle() { Color = Color.Black, Height = height, Width = width };
                    Console.WriteLine(rectangle);
                }
                else if (clr == 'w')
                {
                    Shape rectangle = new Rectangle() { Color = Color.White, Height = height, Width = width };
                    Console.WriteLine(rectangle);
                }
            }
        }
    }
}