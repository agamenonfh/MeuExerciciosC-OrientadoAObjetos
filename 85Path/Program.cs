using System;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\TEMP\File1.txt";

            Console.WriteLine($"Path.DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"Path.GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"Path.PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"Path.GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"Path.GetFileNameWithoutExtension(path): {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Path.GetExtension(path): {Path.GetExtension(path)}");
            Console.WriteLine($"Path.GetFullPath(path): {Path.GetFullPath(path)}");
            Console.WriteLine($"Path.GetTempPath: {Path.GetTempPath()}");
        }
    }
}