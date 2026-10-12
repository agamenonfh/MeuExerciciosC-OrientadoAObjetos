using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities.Exceptions;

namespace Course.Entities
{
    internal class Account
    {
        private int _Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        List<Account> accounts = new List<Account>();
        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            _Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds the withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance.");
            }
            Balance -= amount;
            Console.WriteLine($"New balance: {Balance:F2}");
        }

    }
}
