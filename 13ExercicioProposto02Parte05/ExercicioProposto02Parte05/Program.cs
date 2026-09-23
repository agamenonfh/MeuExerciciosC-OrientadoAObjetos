//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar.
//Codigo  |  Especificação do item  |  Preço
//1       | Cachorro Quente        | 4.00
//2       | X-Salada               | 4.50
//3       | X-Bacon                | 5.00
//4       | Torrada Simples        | 2.00
//5       | Refrigerante           | 1.50

using System;
using System.Globalization;

namespace ExercicioProposto02Parte05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            float preço = 0, total = 0;
            string item = "";

            Console.WriteLine("---------- Lachonete do Aga -----------");
            Console.WriteLine("Codigo  | Especificação do item  |  Preço\r\n1       | Cachorro Quente        | 4.00\r\n2       | X-Salada               | 4.50\r\n3       | X-Bacon                | 5.00\r\n4       | Torrada Simples        | 2.00\r\n5       | Refrigerante           | 1.50");
            Console.Write("Digite o código do item consumido: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de itens consumidos: ");
            qtd = int.Parse(Console.ReadLine());

            if (cod == 1)
            {
                item = "Cachorro Quente";
                preço = 4.00f;
            }
            else if (cod == 2)
            {
                item = "X-Salada";
                preço = 4.50f;
            }
            else if (cod == 3)
            {
                item = "X-Bacon";
                preço = 5.00f;
            }
            else if (cod == 4)
            {
                item = "Torrada Simples";
                preço = 2.00f;
            }
            else if (cod == 5)
            {
                item = "Refrigerante";
                preço = 1.50f;
            }
            total = preço * qtd;
            Console.WriteLine("O consumo foi de " + qtd + " " + item + " somando um total de R$ " + total.ToString("F2", CultureInfo.CurrentCulture) + ".");

        }
    }
}