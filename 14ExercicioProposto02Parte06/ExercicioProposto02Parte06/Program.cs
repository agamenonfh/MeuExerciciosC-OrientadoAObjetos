//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
//seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
//nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
using System;
using System.Globalization;

namespace ExercicioProposto02Parte06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n >= 0 && n < 25)
            {
                Console.WriteLine("O número " + n + " está no intervalo entre 0 e 25.");
            }
            else if (n <= 50)
            {
                Console.WriteLine("O número " + n + " está no intervalo entre 25 e 50.");
            }
            else if (n <= 75)
            {
                Console.WriteLine("O número " + n + " está no intervalo entre 50 e 75.");
            }
            else if (n <= 100)
            {
                Console.WriteLine("O número " + n + " está no intervalo entre 75 e 100.");
            }
            else
            {
                Console.WriteLine("Fora de intervalo.");
            }
        }
    }
}