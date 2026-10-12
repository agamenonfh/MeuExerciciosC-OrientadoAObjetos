using System;
using System.Collections.Generic;
using System.Text;

namespace _52ModificadorDeParametrosRef
{
    internal class Calculator
    {
        /* Jeito errado onde a calculadora não funciona
        public static void Triple(int x)
        {
            x = x * 3;
        }
        */
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
