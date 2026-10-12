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
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Emplyee #{i} data:");
                Console.Write("Outsourced (y/n) ? ");
                char outSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee emp = null;

                if (outSourced == 'n' || outSourced =='N')
                {
                    
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else if (outSourced == 'y' || outSourced == 'Y')
                {
                    
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
/*Enter the number of employees: 3
Employee #1 data:
Outsourced (y/n)? n
Name: Alex
Hours: 50
Value per hour: 20.00
Employee #2 data:
Outsourced (y/n)? y
Name: Bob
Hours: 100
Value per hour: 15.00
Additional charge: 200.00
Employee #3 data:
Outsourced (y/n)? n
Name: Maria
Hours: 60
Value per hour: 20.00
PAYMENTS:
Alex - $ 1000.00
Bob - $ 1720.00
Maria - $ 1200.00*/