using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _41EstoqueExemplo2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {

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
