using System;
using System.Globalization;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();//Mesmo a SUperclasse 'Account' sendo abstrata,
                                                     //podemos criar uma lista de contas do tipo Account,
                                                     //pois as subclasses SavingsAccount e BusinessAccount são do tipo Account
                                                     //e somentes instanciamos objetos de Subclasses.
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 1000.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 300.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine($"Total balance: ${sum:F2}");

            // metodos de execução poliformicca

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            double sum2 = 00.0;
            foreach (Account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: ${acc.Balance:F2}");
            }
            foreach (Account acc in list)
            {
                sum2 += acc.Balance;
            }
            Console.WriteLine($"New Total balance: ${sum2:F2}");
        }
    }
}
/*Se a classe Account não pode ser instanciada, por que
simplesmente não criar somente SavingsAccount e
BusinessAccount?
• Resposta:
• Reuso
• Polimorfismo: a superclasse classe genérica nos permite
tratar de forma fácil e uniforme todos os tipos de conta,
inclusive com polimorfismo se for o caso (como fizemos nos
últimos exercícios). Por exemplo, você pode colocar todos
tipos de contas em uma mesma coleção.*/