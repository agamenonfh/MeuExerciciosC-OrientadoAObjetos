//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
//ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
//Se o ponto estiver na origem, escreva a mensagem “Origem”.
//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
//situação.

using System;
using System.Globalization;

namespace ExercicioProposto02Parte07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Plano Carteseano
            Console.WriteLine("Plano Cartesiano");
            Console.Write("Digite os valores de X e Y: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            float x = float.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            float y = float.Parse(coordenadas[1], CultureInfo.InvariantCulture);
            string quadrante = "";

            if (x == 0 && y != 0)
            {
                quadrante = "Eixo X";
            }
            else if (y == 0 && x != 0)
            {
                quadrante = "Eixo Y";
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    quadrante = "Quadrante 1";
                }
                else
                {
                    quadrante = "Quadrante 4";
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    quadrante = "Quadrante 2";
                }
                else
                {
                    quadrante = "Quadrante 3";
                }
            }
            else if (x == 0 && y == 0)
            {
                quadrante = "Origem";
            }
            Console.WriteLine("Com os dado {0:F2}  e {1:F2} que você digitou pertence ao {2} do plano Cartesiano .", x, y, quadrante);
        }
    }
}