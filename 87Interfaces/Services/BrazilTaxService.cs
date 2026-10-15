using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal class BrazilTaxService : ITaxService // isso aqui não é herança, mas sim uma realização da interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
