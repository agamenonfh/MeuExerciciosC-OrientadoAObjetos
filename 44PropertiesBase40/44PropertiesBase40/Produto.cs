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
        private double _preco;
        // o 'private' não permite que a linha de código seja alterar a qualquer momento além daquilo que está programado.
        private int _quantidade;

        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set { if (value != null & value.Length > 1)
                {
                    _nome = value;
                } }
        }
        // Imlementando os métodos Get - Set
        
        public double Preco
        {
            get
            {
                return _preco;
            }
        }
        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }
       
        public double ValorTotalEmEstoque()

        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidade(s), Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + ".";
        }


    }
}
