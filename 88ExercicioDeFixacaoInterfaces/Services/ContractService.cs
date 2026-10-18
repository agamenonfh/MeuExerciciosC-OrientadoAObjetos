using Course.Entities;
using Course.Services;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using System.Globalization;

namespace Course.Services
{
    internal class ContractService
    {
        public int Month { get; set; }
        private IOnlinePaymentService _onlinePaymentService;
        List<ContractService> contractServices = new List<ContractService>();
        public void ProcessContract(Contract contract,Installment installment, int month)
        {
            Month = month;
            for (int i = 1; i <= Month; i++)
            {
                DateTime duoDate = contract.StartDate.AddMonths(i);
                double amontInstallment = contract.TotalValue / Month;
                double installmentFee = _onlinePaymentService.PaymentFee(amontInstallment);
                double installmentAddedInterest = _onlinePaymentService.Interest(installmentFee, i);
                installment = new Installment(duoDate, installmentAddedInterest);
                
            }
        }
    }
}
