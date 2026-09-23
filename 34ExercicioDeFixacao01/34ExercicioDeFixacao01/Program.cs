using _34ExercicioDeFixacao01;
using System;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = {0:F2}", x.Area(), CultureInfo.InvariantCulture);
            Console.WriteLine("PERÍMETRO = {0:F2}", x.Perimetro(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = {0:F2}", x.Diagonal(), CultureInfo.InvariantCulture);
        }
    }
}