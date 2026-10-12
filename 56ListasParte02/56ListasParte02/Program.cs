using System;
using System.Collections.Generic;

namespace ListasParte02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>/* Abriu o camndo de listas */ list /*Indicou qual o nome da lista*/ = new List<string>()/*Instanciou a lista*/;

            //Esse comando abaixo adiciona na ordem em que está escrito o codigo um item naquela mesma posição
            list.Add("Maria");//Posição 0
            list.Add("Alex");//Posição 1
            list.Add("Bob");//Posição 2
            list.Add("Anna");//Posição 3

            //Esse comando insere um item na posição desejada e definida no comando.
            list.Insert(2/*Posição*/, "Marco"/*item*/);

            foreach (string obj in list) //Comando semelhante ao for, porém com indeterminado quantidade de itens.
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count/*Comando que lê a quantidade de itens na lista*/);

            //Comando para encontrar pedricado, onde o predicado é uma função que tem a ver com o assunto de lâmbida que pega um valor e retorna verdadeiro ou falso
            //conforme a condição afirmada.
            string s1 = list.Find(Test);
            Console.WriteLine("First name that starts with 'A': " + s1);

            //Essa função abaixo serve também para ser referencia para o Find ou Findlast;
            static bool Test(string s)
            {
                return s[0] == 'A';
            }

            //outra forma mais resumida de escrever a função Find é com o esquema de lambida como descrito abaixo
            /*"string"*/
            s1 = list.Find(x => x[0] == 'A'/*=>Essa é a expressão LAMBIDA*/);
            Console.WriteLine("First name that starts with 'A': " + s1);

            //FINDLAST
            //Comando para encontrar pedricado, onde o predicado é uma função que tem a ver com o assunto de lâmbida que pega um valor e retorna verdadeiro ou falso
            //conforme a condição afirmada.
            string s2 = list.FindLast(Test2);
            Console.WriteLine("First name that starts with 'A': " + s2);

            //Essa função abaixo serve também para ser referencia para o Find ou Findlast;
            static bool Test2(string s)
            {
                return s[0] == 'A';
            }

            //outra forma mais resumida de escrever a função Find é com o esquema de lambida como descrito abaixo
            /*"string"*/
            s2 = list.FindLast(x => x[0] == 'A'/*=>Essa é a expressão LAMBIDA*/);
            Console.WriteLine("First name that starts with 'A': " + s2);

            //Encontrar primeira ou última posição de elemento da lista que satisfaça um
            //predicado: list.FindIndex, list.FindLastIndex
               //OBS.: o Index é a posição na qual a condição será satisfeita.
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position starts with 'A': " + pos1);

            int last = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("The last position stars with 'A': " + last);

            //Filtrar a lista com base em um predicado: list.FindAll
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------------------");
            //Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange;

            list.RemoveRange(2/*A partir da posição 2*/, 2/*Remover 2 posições*/);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

           
        }
    }
}