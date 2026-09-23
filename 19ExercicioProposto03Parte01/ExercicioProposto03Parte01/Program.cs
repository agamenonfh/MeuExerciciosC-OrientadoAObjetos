//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

using System;
using System.Globalization;
using System.Net.Mail;

namespace ExercicioProposto03Parte01
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002, senhaDigitada, count = 0;
            Console.WriteLine("Digite sua senha: ");
            senhaDigitada = int.Parse(Console.ReadLine());
            
            while (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite sua senha novamente: ");
                senhaDigitada = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Acesso Permitido");
            
        }
    }
}