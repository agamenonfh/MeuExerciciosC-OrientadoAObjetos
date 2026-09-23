using _50ExercicioDeFixacaoVetores;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many rooms will be rented? ");
            int N = int.Parse(Console.ReadLine());
            Inquilino[] renter = new Inquilino[10];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Rent #{0}", (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                renter[room] = new Inquilino { Room = room, Name = name, Email = email };
                
            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {
               
                    Console.WriteLine(renter[i]);
                             
            }
        }
    }
}