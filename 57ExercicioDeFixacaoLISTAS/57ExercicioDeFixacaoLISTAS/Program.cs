using _57ExercicioDeFixacaoLISTAS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
            N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma
            mensagem e abortar a operação.Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada.*/

            Console.Write("How many employees will be registred? ");
            int N = int.Parse(Console.ReadLine());            
            List<Employee> list = new List<Employee>();
            
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + " :");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will receive a salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This employee doesn't exist.");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}