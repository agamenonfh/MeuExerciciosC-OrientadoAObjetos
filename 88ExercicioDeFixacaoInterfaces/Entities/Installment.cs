using System;
using System.Security.AccessControl;
using Course.Entities;
namespace Course.Entities
{
    internal class Installment
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        List<Installment> installments = new List<Installment>();
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
