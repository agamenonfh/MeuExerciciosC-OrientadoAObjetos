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
            string path = @"C:\Users\TEMP";
            try
            {
                // If i want to change the 'IEnumerable<Type>' to 'var' it's acceptable, because the program will get the IEnumerable method
                // and the 'var' will make the 'using System.Collections.Generic' not required.
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
                Directory.CreateDirectory($@"{path}\novapasta");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocurred an error\n{e.Message}");
            }
            string path2 = @"C:\Users\agame\Videos";
            Console.WriteLine($"Path exists: {Directory.Exists(path2)}");
        }
    }
}