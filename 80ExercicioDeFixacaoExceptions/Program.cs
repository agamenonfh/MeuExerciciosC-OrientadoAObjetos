using System;
using System.Globalization;
using Course.Entities.Exceptions;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Format exception: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"There's an exception: {e.Message}");
            }
        }
    }
}