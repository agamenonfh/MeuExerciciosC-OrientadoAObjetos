using System;
using System.Globalization;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\TEMP\Filex.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocurred an error\n{e.Message}");
            }
        }
    }
}