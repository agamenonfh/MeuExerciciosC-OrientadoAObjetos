using _36ExercicioDeFixacao03;
using System;
using System.Globalization;

namespace ExercicioDeFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            Console.Write("Nome do Aluno: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            p1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(p1);
        }
    }
}