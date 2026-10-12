using _53ModificadorOUT;
using System;
using System.Globalization;

namespace ModificadorOUT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}