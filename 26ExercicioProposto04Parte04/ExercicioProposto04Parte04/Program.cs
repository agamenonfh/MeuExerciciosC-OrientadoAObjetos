//Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
//segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

using System;
using System.Globalization;

namespace URI1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double x = int.Parse(v[0]);
                double y = int.Parse(v[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    double r = x / y;
                    Console.WriteLine(r.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        
    }
}