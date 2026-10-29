using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Service
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // Quando se usa a interface IComparable com a função CompareTo(obj) ele tem que retornar um valor maior que 0.
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
