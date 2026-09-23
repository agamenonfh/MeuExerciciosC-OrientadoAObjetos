//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
//de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
//conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
//peso 5.

using System;
using System.Globalization;

 namespace URI1079
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de casos de teste: ");
            int N = int.Parse(Console.ReadLine());
            float media;

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                float v1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
                float v2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
                float v3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
                media = (v1 * 2 + v2 * 3 + v3 * 5) / 10;
                Console.WriteLine("{0:F1}", media);
            }
        }
    }
}