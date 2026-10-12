using System;
using System.Collections.Generic;
using System.Text;
using ExericioResolvidoEnum01.Entities.Enums;
using ExericioResolvidoEnum01.Entities;

namespace ExericioResolvidoEnum01.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);

        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int mounth)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mounth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
