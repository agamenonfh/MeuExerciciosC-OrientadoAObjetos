//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
//Lembrando que, por definição, fatorial de 0 é 1.

using System;
using System.Globalization;

namespace URI1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;
            if (N == 0)
            {
                Console.WriteLine(1);
            }
            else if (N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    fatorial = fatorial * (N - i);
                }
                Console.WriteLine(fatorial);
            }
        }
    }
}