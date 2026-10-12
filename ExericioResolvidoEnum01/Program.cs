using System;
using System.Globalization;
using ExericioResolvidoEnum01.Entities;
using ExericioResolvidoEnum01.Entities.Enums;

namespace ExericioResolvidoEnum01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for Department's name
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            
            //Ask for Worker data
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLvl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Create Department and Worker objects
            Departament dept = new Departament(departmentName);
            Worker worker = new Worker(workerName, workerLvl, baseSalary, dept);

            //Ask for contracts
            Console.Write("How many contracts to this worker? ");
            int contractCount = int.Parse(Console.ReadLine());
            
            //Loop to get contract data
            for (int i = 1; i <= contractCount; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(contractDate, valuePerHour, hours);
                worker.AddContract(contract);
            }

            //Ask for month and year to calculate income
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            DateTime date = DateTime.ParseExact(monthAndYear, "MM/yyyy", CultureInfo.InvariantCulture);
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}