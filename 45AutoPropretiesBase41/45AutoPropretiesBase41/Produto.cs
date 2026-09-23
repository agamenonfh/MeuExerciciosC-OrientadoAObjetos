using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _41EstoqueExemplo2
{
    internal class Produto
    {
        // o padrão por convenção é que o atributo receba o underline '_' seguido pelo nome do atributo sempre em minúsculo como está escrito abaixo.
        private string _nome;
        // O CÓDIGO DO PREÇO VAI SER PROGRAMADO EM AUTO PROPERTIES
        public double Preco { get; private set;  }
        // o 'private' não permite que a linha de código seja alterar a qualquer momento além daquilo que está programado.
        public int Quantidade { get; private set; }
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // Esse código a baixo é uma manipulação manual do programa em get - set.
        public string Nome
        {
            get { return _nome; }
            set { if (value != null & value.Length > 1)
                {
                    _nome = value;
                } }
        }
        // Imlementando os métodos Get - Set
        
       
       
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
