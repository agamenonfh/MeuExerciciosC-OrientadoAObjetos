//Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
//cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
//menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

using System;
using System.Globalization;

namespace ExercicioProposto03Parte02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string quadrante = "";

            Console.Write("Digite as coordenadas (X, Y) dos pontos (ou digite 0 para encerrar): ");
            string[] input = Console.ReadLine().Split(' ', ',');
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {
                if ( x > 0)
                {
                    if ( y > 0)
                    {
                        quadrante = "primeiro";
                    }
                    else
                    {
                        quadrante = "quarto";
                    }
                }
                if (x < 0)
                {
                    if (y > 0)
                    {
                        quadrante = "segundo";
                    }
                    else
                    {
                        quadrante = "terceiro";
                    }
                }
                Console.Write(quadrante + "\nDigite as coordenadas (X, Y) dos pontos (ou digite 0 para encerrar): ");
                input = Console.ReadLine().Split(' ', ',');
                x = double.Parse(input[0], CultureInfo.InvariantCulture);
                y = double.Parse(input[1], CultureInfo.InvariantCulture);

            }
        }
    }
}