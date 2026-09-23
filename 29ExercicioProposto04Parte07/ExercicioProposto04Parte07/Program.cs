//Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
//começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
//exemplo.

using System;

namespace URI1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2.0), Math.Pow(i, 3.0));
            }
        }
    }
}