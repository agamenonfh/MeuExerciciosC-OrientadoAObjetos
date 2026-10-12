using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TRY-Catch
            try
            {
                Console.WriteLine("------------- try _ Catch----------------");
                Console.WriteLine("No exemplo o Nélio usou uma divisão para mostrar como funciona o Try Catch para tratar de exceções!");
                Console.WriteLine("Vamos lá?!");
                Console.WriteLine();
                Console.WriteLine("Primeiro vão ler 2 números:");
                string[] num = Console.ReadLine().Split(' ');
                int n1 = int.Parse(num[0]);
                int n2 = int.Parse(num[1]);

                Console.WriteLine("Agora que obtemos dois dados, atribuimos eles em uma lista 'num' transformamo-os em dados Int32, " +
                    "\nvamos tratar todas as possíveis exceções oriundas dos dados obtidos.");


                double result = n1 / n2;
                    Console.WriteLine($"O resultado da divisão, caso não tenha acontecido algo erro, é {result}.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error! {e.Message}");
            }
        }
    }
}