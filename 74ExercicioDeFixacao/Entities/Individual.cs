using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities;

namespace Course.Entities
{
    class Individual : Contribuinte
    {
        public double HealthExpenditures { get; set; }
        List<Individual> Individuals = new List<Individual>();
        public Individual()
        {

        }
        public Individual(string name, double annualIncomme, double healthExpenditures) : base(name, annualIncomme)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxesCalc()
        {
            double rate = AnnualIncomme < 20000.0 ? 0.15 : 0.25;
            return Taxes = (AnnualIncomme * rate) - (HealthExpenditures * 0.5);
        }
        public void AddIndividuals(Individual individual)
        {
            Individuals.Add(individual);
        }
        public void RemoveIndividuals(Individual individual)
        {
            Individuals.Remove(individual);
        }

    }
}

