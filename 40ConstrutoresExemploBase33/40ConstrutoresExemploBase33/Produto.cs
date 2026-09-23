using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _33EstoqueExemplo2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Esse aqui abaixo é o CONSTRUTOR o qual obriga o 'Program.cs' informar as entradas dos dados antes da instâniação do membro, ou posterior à entrada de dados.
        public Produto(string nome,  double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade(s), Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".";
        }


    }
}
