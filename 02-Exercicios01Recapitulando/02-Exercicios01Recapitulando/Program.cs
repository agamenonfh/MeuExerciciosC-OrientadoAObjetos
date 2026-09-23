using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Exercicio01Recapitulando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de Soma");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = x + y;
            Console.WriteLine(soma);

            Console.WriteLine("Area de um circulo");
            double x1 = double.Parse(Console.ReadLine());
            double areaDoCirculo = x1 * 3.14159
            Console.WriteLine(areaDoCirculo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Diferenca de Produtos");
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            int produto1 = a * b;
            int produto2 = c * d;
            Console.WriteLine(produto1 -  produto2);



        }
    }
}