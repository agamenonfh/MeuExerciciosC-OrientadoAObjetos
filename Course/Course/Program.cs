using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char sexo = 'F';
            char letra = '\u0041'; // Tabela Unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Debora Farias";
            object obj1 = "Agamenon Farias";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            byte n9 = byte.MaxValue;
            byte n10 = byte.MinValue;
            decimal n11 = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(sexo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
           Console.WriteLine(n11);
        }
    }
}