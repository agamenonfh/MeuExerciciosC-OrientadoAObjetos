using _49VetoresParte02Exemplo02;
using System;
using System.Globalization;

namespace Exemplo02VetoresParte02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // Vetor tipo Class

            Product[] vect = new Product[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < N; i++)
            {                
                sum += vect[i].Price;
            }

            double avg = sum / N;

            Console.WriteLine("AVERAGE PRICE = {0:F2}", avg);
        }
    }
}