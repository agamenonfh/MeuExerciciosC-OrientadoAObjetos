// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

using _31PessoaMaisVelha;
using System;

namespace Exercico01parte01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;
            pessoa1 = new Dados();
            pessoa2 = new Dados();
            string maisVelha = "";

            Console.WriteLine("Dados da 1ª pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da 2ª pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());
            if (pessoa1.Idade < pessoa2.Idade)
            {
                maisVelha = pessoa2.Nome;
            }
            else
            {
                maisVelha = pessoa1.Nome;
            }
            Console.WriteLine("Pessoa mais velha: {0}.", maisVelha);
        }
    }
}