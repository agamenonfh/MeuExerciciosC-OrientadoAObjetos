    using System;
using System.Collections.Generic;
using System.Text;

namespace _51ModificadoresDeParametrosParams
{
    internal class Calculator // Modificador params
    {
        public static int Sum(params int[] numbers) // params é um modificadore de parametros que permite que no Programa não seja necessario instanciar com o new
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
