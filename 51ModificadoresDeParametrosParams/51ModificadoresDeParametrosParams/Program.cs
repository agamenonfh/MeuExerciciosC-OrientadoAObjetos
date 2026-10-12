using _51ModificadoresDeParametrosParams;
using System;
using System.Globalization;

namespace ModificadoresParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4, 3, 2, 4, 2, 2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}