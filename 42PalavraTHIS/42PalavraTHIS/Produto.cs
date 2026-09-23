using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _42EstoqueExemplo3
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        //O Construtor é alocado na memória HEAP que é uma melhor memória para ALOCAR e DESACLOCAR 
        public Produto()
        {
            Quantidade = 10;
        }
        // A palavra THIS É uma referência para o própios objeto.
        public Produto(string nome, double preco) : this()// e Também referenciar outro construtor em um construtor reutilizando os parâmetros do construtor anterior sem que haja a necessidade de 
                                                          // repetir o código nesse outro construtor. Nesse caso o Quantidade = 10;
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco,  int Quantidade) : this (nome, preco) // e Também referenciar outro construtor em um construtor reutilizando os parâmetros do construtor anterior sem que haja a necessidade de 
                                                                                        // repetir o código nesse outro construtor. Nesse caso o this (nome, preco)
        {  // \/ Esse parâmetro é o nome do próprio objeto              //  /\  o THIS 
            this.Quantidade = Quantidade;
        }                   // /\ esse parâmetro é a entrada referenciada no Program.cs
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
