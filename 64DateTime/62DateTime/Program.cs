using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2026, 09, 28);
            DateTime d2 = new DateTime(2026, 09, 28, 18, 25, 29);
            DateTime d3 = new DateTime(2026, 09, 28, 18, 25, 29, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine();
            DateTime d7 = DateTime.Parse("1989-07-11");
            DateTime d8 = DateTime.Parse("1989-07-11 15:00:00");
            DateTime d9 = DateTime.Parse("29/07/1992");
            DateTime d10 = DateTime.Parse("29/07/1992 15:00:00");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine();
            DateTime d11 = DateTime.ParseExact("1989-07-11", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("29/07/1992 15:02:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}