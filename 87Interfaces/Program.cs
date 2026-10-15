using Course.Entities;
using Course.Services;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental date");
            try
            {
                Console.WriteLine("Car model:");
                string model = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy HH:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Enter price per hour: ");
                double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));

                RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine($"Invoice:\n{carRental.Invoice}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"There's an error:\n{e.Message}");
            }
        }
    }
}