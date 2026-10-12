using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\agame\Desktop";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocurred an error\n{e.Message}");
            }
        }
    }
}