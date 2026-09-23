using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace ExercicioProposto02Parte04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            Console.WriteLine("----------- Calculadora de Duração de Jogo -----------");
            Console.Write("Digite aqui a hora inicial e final do jogo: Exemplo: 16 15: ");
            string[] tempo = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(tempo[0]);
            int horaFinal = int.Parse(tempo[1]);

            if (horaInicial < horaFinal)
            {
                int duracao = horaFinal - horaInicial;
                Console.WriteLine("O jogo teve uma duração de " + duracao + " hora(s)");
            }
            else
            {
                int duracao = (24 - horaInicial) + horaFinal;
                Console.WriteLine("O jogo teve uma duração de " + duracao + " horas(s).");
            }
        }
    }
}