using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace SobreposicaoVirtualOverrideBase.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
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
