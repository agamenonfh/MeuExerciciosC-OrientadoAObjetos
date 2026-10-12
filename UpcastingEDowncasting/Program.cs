using System;
using System.Globalization;
using UpcastingEDowncasting.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc; // O objeto do tipo BusinessAccount é convertido para o tipo Account
                                 // isso é possível porque BusinessAccount é uma subclasse de Account
                                 // logo, quando eu faço uma conversão de uma businessAccount para uma Account, eu estou fazendo um upcasting.
                                 // Porque toda Subclasse é uma derivação da SuperClasse principal.

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Upcasting
                                                                         // Eu percebo que quando eu faço o Upcasting
                                                                         // é possível porque a Sublasse ja possue os atributos da SuperClasse principal
                                                                         // .

            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); // Upcasting de uma savingsAccount para uma account, pois a savingsAccount é uma subclasse de account.

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2; // Downcasting
                                                          // Quando é feito um Dowcasting, a ação é de converter um objeto SuperClasse em Subclasse.
                                                          // Por essa razão se faz necessário o Casting Subclasse variável = (Subclasse)variável.SuperClasse
                                                          // Pois, caso contrário haveria um erro de compilação, pois não é possível converter implicitamente uma SuperClasse em uma Subclasse.
            acc4.Loan(100.0);

            //acc2.Loan(100.0); // Erro de compilação, pois a variável acc2 é do tipo SuperClasse(Account), e a Superclasse Account não possui o método Loan
            // Tal qual a SubClasse BusinessAccount, mesmo que essa 'variável' seja instanciada como uma Subclasse na linha de código.

            //BusinessAccount acc5 = (BusinessAccount)acc3; // Erro de compilação, pois a variável acc3 é do tipo SuperClasse(Account) porém instanciada como uma SubClasse(SavingsAccount)
            // e assim é impossível intanciá-la como BusinessAccount por serem de SubClasses diferentes.

            // o DOWNCASTING é perigoso pois se fou feito um DOWNCASTING para uma SubClass diferente aparecerá um erro de compilação, pois a SubClasse não possui os atributos da outra SubClasse.
            //nessa ocasião se fará necessario um teste com o if (variavel is SubClasse) para verificar se a variável é do tipo SubClasse antes de fazer o Downcasting.
            if (acc3 is BusinessAccount) // Verifica se a variável acc3 é do tipo BusinessAccount
            {
                BusinessAccount acc5 = acc3 as BusinessAccount ; // Downcasting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else if (acc3 is SavingsAccount) // Verifica se a variável acc3 é do tipo SavingsAccount
            {
                SavingsAccount acc5 = (SavingsAccount)acc3; // Downcasting
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}