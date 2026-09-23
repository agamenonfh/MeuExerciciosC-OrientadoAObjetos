using System;
using System.Globalization;

namespace ExemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.Write("Digite um número: ");
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0)
            {              
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número: ");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número inválido.");
        }
    }
}