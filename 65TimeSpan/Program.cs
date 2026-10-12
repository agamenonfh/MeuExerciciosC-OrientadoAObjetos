using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0, 1, 30);
            TimeSpan t3 = new TimeSpan(900000000L); //Quantidade de TICKS L indica um long
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2.Ticks);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine($"DateTime d1 = DateTime.Parse('2000-08-15 13:08:58'); gera: {d1}");
            Console.WriteLine($"d1.Kind: {d1.Kind}");
            Console.WriteLine($"d1.ToLocalTime(): {d1.ToLocalTime()}");
            Console.WriteLine($"d1.ToUniversalTime(): UTC {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"DateTime d2 = DateTime.Parse('2000-08-15T15:08:58Z'); gera: {d2}");
            Console.WriteLine($"d2.Kind: {d2.Kind}");
            Console.WriteLine($"d2.ToLocalTime: {d2.ToLocalTime()}");
            Console.WriteLine($"d2.ToUniversalTime: UTC {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado! Isso aqui pode te dar um problema em mostrar uma data em iso8601
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));//aqui você converteu para UTC para depois converter para string.
        }
    }
}