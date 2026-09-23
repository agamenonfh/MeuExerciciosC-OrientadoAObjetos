//Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (suponha medidas válidas).
//Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
//A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte (fórmula de Heron):
// Área = √p(p - a)(p - b)(p - c), onde p = (a + b + c) / 2

using System;
using System.Globalization;

namespace ExemploSemOrientaxcaoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa, xb, xc, ya, yb, yc, areaX, areaY, px, py;
            Console.WriteLine("Entre com os dados do triângulo X:");
            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com os dados do triângulo Y:");
            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            px = (xa + xb + xc) / 2.0;
            py = (ya + yb + yc) / 2.0;
            areaX = Math.Sqrt(px * (px - xa) * (px - xb) * (px - xc));
            areaY = Math.Sqrt(py * (py - ya) * (py - yb) * (py - yc));

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