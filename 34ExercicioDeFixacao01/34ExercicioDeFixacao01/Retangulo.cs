using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _34ExercicioDeFixacao01
{
    internal class Retangulo
    {
        public double A;
        public double B;

        public double Area()
        {
            return A * B;
        }
        public double Perimetro()
        {
            return 2 * (A + B);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(A, 2.0) + Math.Pow(B, 2.0));
        }


    }
}
