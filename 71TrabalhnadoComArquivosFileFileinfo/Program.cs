using System;
using System.IO;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\TEMP\File1.txt";
            //outra forma de digitar o caminho para o arquivo é C:\\User\\TEMP\\File.txt porém o C#
            //possue o '@' 'arroba' para permitir a digitaçãop com apenas uma barra invertida \.
            string targetPath = @"C:\Users\TEMP\File2.Txt";
            // Nesse exemplo, nao sei se entodos, quanto tratarmos de arquivos iremos colocar o tratamento do arquivo no TRY
            // para podermos pegar os erros ocorridos na tratação do(s) arquivo(s).
            try
            {
                /*FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);*/
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}