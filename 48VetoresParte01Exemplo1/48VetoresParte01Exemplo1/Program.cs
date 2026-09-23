using System;
using System.Globalization;

namespace Exemplo01VetoresParte01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            /* Maneira antiga
            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += altura;
            }
            double media = soma / N;
            Console.WriteLine("AVERAGE HEIGHT = {0}.", media.ToString("F2", CultureInfo.InvariantCulture));
            */

            double[] vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }

            double avg = soma / N;
            Console.WriteLine("AVERAGE HEIGHT = {0:F2}", avg);
        }
    }
}