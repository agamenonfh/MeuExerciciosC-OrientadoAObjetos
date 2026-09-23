using System;
using System.Globalization;

namespace Convencoes //PascalCase
{
    class ContaBancaria //Pascal Case
    {
        public string Titular {  get; set; }
        public double _saldo; //Padrao _xxxXxxx

        public void Deposito(double quantia) // Camel Case
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
    }
}