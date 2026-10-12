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
            List<Product> products = new List<Product>(); // Criei e instanciei a lista de produtos

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime manDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manDate));
                }
                else if(type == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("Invalid product type. Please enter 'c', 'u', or 'i'.");
                    i--; // Decrement i to repeat this iteration
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}