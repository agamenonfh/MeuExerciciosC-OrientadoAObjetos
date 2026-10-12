using _52ModificadorDeParametrosRef;
using System;
using System.Globalization;

namespace ModificadorDeParametrosREF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}