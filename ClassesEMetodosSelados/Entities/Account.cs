using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEMetodosSelados.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }
        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void Withdraw(double amount)// Esse metodo é marcado como virtual, o que significa que ele pode ser sobrescrito por classes derivadas,
                                                   // chamadas de Subclass.
        {
            Balance -= amount + 5.00 /*Fee(taxa)*/ ;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
