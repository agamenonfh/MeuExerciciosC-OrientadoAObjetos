// Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
// Em seguida:
// mostrar os dados do produto;
// o valor total em estoque (preço * quantidade) e permitir que o usuário adicione ou remova produtos do estoque. Mostrar novamente os dados atualizados do produto.
// Para resolver este problema, você deve criar uma CLASSE conforme projeto mostrado.

using _33EstoqueExemplo2;
using System;
using System.Globalization;

namespace ExercicioEstoqueExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + prod);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + prod);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + prod);
        }
    }
}