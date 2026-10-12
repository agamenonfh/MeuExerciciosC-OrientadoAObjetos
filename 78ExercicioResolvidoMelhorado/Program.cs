using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esse método também é ruim pois a saída de erro retorna uma string e isso prejudica a semântica da operação
            // E ainda não é possível tratar exceções em contrutores.
            // A lógica fica estruturada em condicionais aninhadas e isso é como se fosse um HADUKEN de código! kkkkk
            // .
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

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine($"Erro in reservation: {error}.");
                }
                else
                {
                    Console.WriteLine($"Reservation: {reservation}");
                }
            }
        }
    }
}