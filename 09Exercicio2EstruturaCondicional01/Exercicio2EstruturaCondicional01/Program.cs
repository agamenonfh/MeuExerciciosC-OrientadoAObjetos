using System;
using System.Globalization;

namespace Exercicio2EstruturaCondicional01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 0) {
                Console.WriteLine("Esse número é NEGATIVO.");
                    }
            else if (x > 0)
            {
                Console.WriteLine("Esse número NÃO É NEGATIVO.");
            }
            else
            {
                Console.WriteLine("O número é ZERO.");
            }

        }
    }
}