// Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
// Em seguida:
// mostrar os dados do produto;
// o valor total em estoque (preço * quantidade) e permitir que o usuário adicione ou remova produtos do estoque. Mostrar novamente os dados atualizados do produto.
// Para resolver este problema, você deve criar uma CLASSE conforme projeto mostrado.

using _41EstoqueExemplo2;
using System;
using System.Globalization;

namespace ExercicioEstoqueExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p);
        }
    }
}