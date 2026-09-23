using System;
using System.Globalization;
//Classes são tipos referência que não devem ser entendidas como caixas, mas sim como "tentáculos" (ponteiros) para caixas.

//Valor "null" são tipos referência que aceitam valor null, que indica que a variável aponta para ninguém.

// Tipos valor STRUCTS são caixas e não ponteiros como o variável double x, y.
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is Null");

            double a = x ?? 0.0;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // A variável double quando Nullable e setado em 0.0 retorna em .HasValue 'True'.
            double? c = 0.0;

            Console.WriteLine(c.GetValueOrDefault());
            Console.WriteLine(c.HasValue);
        }
    }
}