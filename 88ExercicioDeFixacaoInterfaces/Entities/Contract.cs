using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Contract
    {
        public int _Number { get; private set; }
        public DateTime StartDate { get; set; }
        public double TotalValue { get; set; }
        public int Installment { get; set; }

        public int Month { get; set; }
        public Contract(int number, DateTime startDate, double totalValue, int month)
        {
            _Number = number;
            StartDate = startDate;
            TotalValue = totalValue;
            Installment = month;
        }
    }
}
