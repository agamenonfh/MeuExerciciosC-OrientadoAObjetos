using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _39ExercicoFixacaoDOLLAR
{
    internal class ConversorDeMoeda
    {
        public static double Cotacao;

        public static double Compra;
        public static double Conversor()
        {
            return Cotacao * Compra + ((Compra * 6 / 100) * Cotacao);
        }

        public override string ToString()
        {
            return Conversor().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
//Metodo de Resolução do Nélio
//namespace Course
//{
//    class ConversorDeMoeda
//    {
//        public static double Iof = 6.0;
//        public static double DolarParaReal(double quantia, double cotacao)
//        {
//            double total = quantia * cotacao;
//            return total + total * Iof / 100.0;
//        }
//    }
//}