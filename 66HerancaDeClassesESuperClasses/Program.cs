using System;
using System.Globalization;
using HerancaDeClassesESuperClasses.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAcount account = new BusinessAcount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            // account.Balance += 200.0;    'O código não compila, pois a propriedade Balance é somente leitura (read-only) na classe base Account.
        }
    }
}