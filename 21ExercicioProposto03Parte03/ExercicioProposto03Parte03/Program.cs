//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
//exemplo.

using System;
using System.Globalization;

namespace ExercicioProposto03Parte03
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0 , diesel = 0;
            Console.WriteLine("Por favor, informe o tipo de combustível abastecido (1.Álcool 2.Gasolina 3.Diesel 4.Fim): ");
            int cod = int.Parse(Console.ReadLine());

            while (cod != 4)
            {
                if (cod == 1)
                {
                    alcool++;
                }
                else if (cod == 2)
                {
                    gasolina++;
                }
                else if (cod == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Código inválido. Por favor, informe um código válido (1.Álcool 2.Gasolina 3.Diesel 4.Fim): ");
                }
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO!\nAlcool: {0}.\nGasolina: {1}.\nDiesel: {2}.", alcool, gasolina, diesel);
        }
    }
}