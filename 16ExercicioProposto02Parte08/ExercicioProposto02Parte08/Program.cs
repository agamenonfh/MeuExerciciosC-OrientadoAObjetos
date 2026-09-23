//Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
//que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
//qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
//Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
//mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

// Renda                    | Imposto de Renda
// Até 2000.00              | Isento
// De 2000.01 até 3000.00   | 8%
// De 3000.01 até 4500.00   | 18%
// Acima de 4500.00         | 28%

//Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
//salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
//de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
//duas casas decimais.

using System;
using System.Globalization;

namespace ExercicioProposto02Parte08
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda, imposto;
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string isento = "Isento";

            if (renda <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (renda <= 3000.00)
            {
                imposto = (renda - 2000.00) * 8 / 100;
            }
            else if (renda <= 4500.00)
            {
                imposto = (renda - 3000.00) * 18 / 100 + (1000 * 8 / 100);
            }
            else
            {
                imposto = (renda - 4500.00) * 28 / 100 + (1500 * 18 / 100) + (1000 * 8 / 100);
            }
            if (imposto == 0.00)
            {
                Console.WriteLine(isento);
            }
            else
            {
                Console.WriteLine("Total em imposto = R$ {0:F2}.", imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}