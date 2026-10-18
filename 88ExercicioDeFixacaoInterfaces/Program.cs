using System;
using System.Globalization;
using Course.Entities;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int contractNumber = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy):");
                DateTime contractInitialDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int numberOfInstallments = int.Parse(Console.ReadLine());

                Contract contract = new Contract(contractNumber, contractInitialDay, contractValue);

                Installment installment = new Installment(numberOfInstallments);
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }
        }
    }
}