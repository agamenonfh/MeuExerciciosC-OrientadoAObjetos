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
            // Para poder utilizar ou alterar os atributos/objetos que estão em 'private' é necessário utilizar o método 'Get-Set'

            p.SetNome("T");
            // o p.SetNome() possue uma condição na execução do código em Produto.cs
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            // A vantagem diosso é a proteção. E a melhor parte en termo de segurança é a possibilidade de se ter total controle do que será e como será alterado ou
            // incrementado qualquer atributo/objeto.
            
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);

        }
    }
}