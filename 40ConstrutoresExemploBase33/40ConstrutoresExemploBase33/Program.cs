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
                       
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //O Construtor faz om que o Objeto a ser instanciado receba obrigatóriamente dados de entrada, sendo assim necessário alocá-lo posterior à entrada de dados ou anterior já informando as entradas base do membro.
            Produto prod = new Produto(nome, preco, quantidade);

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