using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) // usamos o base para chamar características da superclasse,
                                                                                                                              // nesse caso, a classe Account.
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        /* public override void Withdraw(double amount) // A sobreposição é quando você sobrescreve um método da classe base,
                                                     // e a palavra-chave "override" é usada para indicar que você está fornecendo uma nova implementação para o método herdado,
                                                     // o qual foi herdado, nesse exemplo, da Superclasse Account.
        {
            Balance -= amount;
        }*/
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0; // Adicionando uma taxa adicional de 2.0 para saques em contas poupança
        }
    }
}
