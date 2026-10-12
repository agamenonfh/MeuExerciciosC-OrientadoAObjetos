using System;
using System.Collections.Generic;
using System.Text;
using ExericioResolvidoEnum01.Entities.Enums;

namespace ExericioResolvidoEnum01.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
