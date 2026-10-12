using Course.Entities;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessima lógica de Programação, pois está carregando tudo no programa principal quando na verdade deveria estar em posse da Classe Reservation.
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut < checkIn)
            {
                Console.WriteLine("Error in reservarion: Check-out must be a date after check-in.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservatio: {reservation}");
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("The dates must be further the today.");
                }
                else if (checkOut < checkIn)
                {
                    Console.WriteLine("Error in reservarion: Check-out must be a date after check-in.");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}.");
                }
            }
            
        }
    }
}