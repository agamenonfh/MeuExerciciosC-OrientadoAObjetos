using _39ExercicoFixacaoDOLLAR;
using System;
using System.Globalization;

namespace ExercicioFixacaoDOLLA
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda dolar = new ConversorDeMoeda();
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.Write("Quantos dólares você vai comprar ? ");
            ConversorDeMoeda.Compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em Reais = {0:F2}.", ConversorDeMoeda.Conversor());
        }
    }
}
// Metodo de Resoluçao do Nélio

//using System;
//using System.Globalization;
//namespace Course
//{
//   class Program
//   {
//        static void Main(string[] args)
//        {
//            Console.Write("Qual é a cotação do dólar? ");
//            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Quantos dólares você vai comprar? ");
//            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
//            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
//        }