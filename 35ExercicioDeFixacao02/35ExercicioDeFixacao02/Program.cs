using _35ExercicioDeFixacao02;
using System;
using System.Globalization;

namespace ExercicioDeFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();

            Console.WriteLine("Digite os dados do Funcionário:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salário bruto: R$ ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$ ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + p);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double per = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AumentarSalario(per);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}