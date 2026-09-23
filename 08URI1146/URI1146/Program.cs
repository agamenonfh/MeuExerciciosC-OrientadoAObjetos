using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
    static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.Write(i);
                    if (i < x)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());
            } while (x > 0);
        }
    }
}

