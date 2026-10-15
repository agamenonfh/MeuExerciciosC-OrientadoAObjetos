using System;
using System.Globalization;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\TEMP\Vendas.csv";
            Directory.CreateDirectory(@"C:\Users\TEMP\out");
            string targetPath = @"C:\Users\TEMP\out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    string[] vet = line.Split(',');
                    string name = vet[0];
                    double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(vet[2]);
                    double total = price * quantity;
                    string product = ($"{name}, {total.ToString("F2", CultureInfo.GetCultureInfo("en-US"))}");
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocurred an error:\n{e.Message}");
            }
        }
    }
}