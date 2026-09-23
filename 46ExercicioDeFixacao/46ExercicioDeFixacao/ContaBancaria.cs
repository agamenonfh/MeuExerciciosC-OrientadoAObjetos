using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _46ExercicioDeFixacao
{
    internal class ContaBancaria
    {
        private int _numero;
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public double Retirada { get; set; }
        int taxa = 5;
        public ContaBancaria()
        {

        }

        public ContaBancaria(int numero, string titular, double deposito, double retirada)
        {
            _numero = numero;
            Titular = titular;
            Saldo = deposito;
            Retirada = retirada;
        }   
        public int Numero
        {
            get { return _numero; }
            set { if (value > 0)
                {
                    _numero = value;
                } }
        }      
                
        public void AlteracaoDeNome(string titular)
        {
            Titular = titular;
        }
        public void DepositoDeValores(double quantia)
        {
            Saldo += quantia;
        }
        public void RetiradaDeValores(double quantia)
        {
            if (quantia > 0)
            {
                Saldo = Saldo - quantia - taxa;
            }           
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
