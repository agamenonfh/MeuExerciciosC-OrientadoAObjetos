//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
//X, se for o caso.

using System;
using System.Globalization;

namespace URI1067
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}