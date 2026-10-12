using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaDeClassesESuperClasses.Entities
{
    internal class BusinessAcount : Account // O ':' indica que a classe BusinessAccount herda da classe Account
    {
        public double LoanLimit { get; set; }
        public BusinessAcount()
        {
        }
        public BusinessAcount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) // O 'base' chama o construtor da superclasse (Account) para inicializar os atributos herdados
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
