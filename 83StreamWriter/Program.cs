using System;
using System.Globalization;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\TEMP\File1.txt";
            string targetPath = @"C:\Users\TEMP\File2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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