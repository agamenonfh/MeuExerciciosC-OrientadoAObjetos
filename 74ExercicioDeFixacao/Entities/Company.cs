using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities;

namespace Course.Entities
{
    internal class Company : Contribuinte
    {
        public int Employees { get; set; }
        
        List<Company> Companies = new List<Company>();
        public Company()
        {

        }
        public Company(string name, double annualIncomme, int employees) : base(name, annualIncomme)
        {
            Employees = employees;
        }        
        public override double TaxesCalc()
        {
            return AnnualIncomme * (Employees < 10 ? 0.16 : 0.14);
        }
        public void AddCompanies(Company company)
        {
            Companies.Add(company);
        }
        public void RemoveCompanies(Company company)
        {
            Companies.Remove(company);
        }
    }
}
