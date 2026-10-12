using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG      ";
            string s1 = original.ToUpper();
            int n1 = original.IndexOf("bc");

            string cut = original.Substring(3);
            string s6 = original.Replace('a', 'x');

            bool b1 = string.IsNullOrEmpty(original);
            
            Console.WriteLine($"ToUpper: -{s1.ToUpper()}-");
            Console.WriteLine($"ToLower: -{original.ToLower()}-");
            Console.WriteLine($"Trim: -{original.Trim()}-");
            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"LastIdexOf('bc'): {original.LastIndexOf("bc")}");
            Console.WriteLine($"SubString(3): {cut}");
            Console.WriteLine($"SubString(3, 5): {original.Substring(3, 5)}");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{original.Replace("abc", "xy")}");
            Console.WriteLine($"IsNullOrEmpty(original): {b1}");
            Console.WriteLine($"string.IsNullOrWhiteSpace(original): {string.IsNullOrWhiteSpace(original)}");

        }
    }
}