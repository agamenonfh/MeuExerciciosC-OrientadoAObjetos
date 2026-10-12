using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Contribuinte
    {
        public string Name { get; set; }
        public double AnnualIncomme { get; set; }
        public double Taxes { get; set; }

        List<Contribuinte> Contribuintes = new List<Contribuinte>();
        public Contribuinte()
        {

        }
        public Contribuinte(string name, double annualInconme)
        {
            Name = name;
            AnnualIncomme = annualInconme;
        }
        public virtual double TaxesCalc()
        {
            return Taxes;
        }

        public void AddContribuintes(Contribuinte contribuinte)
        {
            Contribuintes.Add(contribuinte);
        }
        public void RemoveContruibuintes(Contribuinte contribuinte)
        {
            Contribuintes.Remove(contribuinte);
        }

        public string ToString()
        {
            return $"{Name}: {TaxesCalc():F2}";
        }
    }
}
