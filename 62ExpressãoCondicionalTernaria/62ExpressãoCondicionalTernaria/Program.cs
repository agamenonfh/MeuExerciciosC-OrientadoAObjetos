using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto = (se isso for verdadeiro) ?'então' isso acontece :'senão' isso acontece.
            double desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05 ;

            Console.WriteLine($"Valor de ${preco:F2} recebe desconto de ${desconto:F2} totalizando ${preco - desconto:F2}");
        }
    }
}