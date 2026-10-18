using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int month)
        {
            return amount * 0.01 * month;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
