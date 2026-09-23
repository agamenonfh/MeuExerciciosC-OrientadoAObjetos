using System;

namespace ExemplosFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            
            double resultado = Maior(n1, n2, n3); // o Maior é uma função que recebe três números inteiros e retorna o maior entre eles.

            Console.WriteLine("Maior = " + resultado);

            //Método sem função

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Maior = " + n1);
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine("Maior = " + n2);
            //}
            //else
            //{
            //    Console.WriteLine("Maior = " + n3);
            //}
        }

        //Aqui foi construído uma função que recebe três números inteiros e retorna o maior entre eles.
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b> c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}