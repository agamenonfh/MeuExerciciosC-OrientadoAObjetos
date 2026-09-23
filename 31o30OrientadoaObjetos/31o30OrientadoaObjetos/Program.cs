//Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (suponha medidas válidas).
//Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
//A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte (fórmula de Heron):
// Área = √p(p - a)(p - b)(p - c), onde p = (a + b + c) / 2

using _31o30OrientadoaObjetos;
using System;
using System.Globalization;

namespace ExemploCemOrientaxcaoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY, px, py;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com os dados do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com os dados do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

            Console.WriteLine("Área do triângulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo X tem a maior área.");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Triângulo Y tem a maior área.");
            }
            else
            {
                Console.WriteLine("Os dois triângulos têm a mesma área.");
            }
        }
    }
}