// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

using _33MediaSalario;
using System;
using System.Globalization;

namespace MediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            Funcionarios pessoa1, pessoa2;
            pessoa1 = new Funcionarios();
            pessoa2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (pessoa1.Salario + pessoa2.Salario) / 2.0;
            Console.WriteLine("Salário médio: R$ {0:F2}", media);

        }
    }
}