using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero correspondente às linhas (M N): ");
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            Console.WriteLine("------------------");

            Console.WriteLine("Now type the numbers which will fill the matrizes: ");

            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] numb = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(numb[j]);
                }
            }

            Console.Write("Which number you wanna search? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                    /* MEU Código
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            bool match = num == mat[i, j];

                            if (match)
                            {
                                Console.WriteLine($"Position {i},{j}:");
                                if (i - 1 < 0)
                                {
                                    if (j - 1 < 0)
                                    {
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                                    }
                                    else if (j + 1 >= n)
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Down: {mat[i + 1, j]}");
                                    }
                                }
                                else if (i + 1 >= m)
                                {
                                    if (j - 1 < 0)
                                    {
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                                    }
                                    else if (j + 1 >= n)
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Down: {mat[i - 1, j]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                                    }
                                }
                                else
                                {
                                    if (j - 1 < 0)
                                    {
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                                    }
                                    else if (j + 1 >= n)
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                                        Console.WriteLine($"Down: {mat[i - 1, j]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                                        Console.WriteLine($"Up: {mat[i - 1, j]}");
                                        Console.WriteLine($"Down: {mat[i - 1, j]}");
                                    }
                                }
                            }
                        }
                    }*/
                }
            }
        }
    }
}