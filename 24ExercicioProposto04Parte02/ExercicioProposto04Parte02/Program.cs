//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
//essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
//essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

using System;

namespace URI1072
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de valores a serem lidos: ");
            int n = int.Parse(Console.ReadLine());
            int cin = 0, cout = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite um valor inteiro: ");
                int x = int.Parse(Console.ReadLine());
                if (10 <= x && x <= 20)
                {
                    cin++;
                }
                else
                {
                    cout++;
                }
            }
            Console.WriteLine("{0} in \n{1} out", cin, cout);
        }
    }
}