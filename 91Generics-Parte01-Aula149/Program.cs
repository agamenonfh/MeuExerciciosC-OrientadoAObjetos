using System;
using System.Globalization;
using Course.Service;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printServices = new PrintService<int>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            try
           { 
                for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printServices.AddValue(x);
            }

            printServices.Print();
                Console.WriteLine($"First: {printServices.First()}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Occurred an error: {e.Message}");
            }
        }
    }
}