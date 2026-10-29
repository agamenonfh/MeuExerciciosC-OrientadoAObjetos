using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entites
{
    internal class Products : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Products))
            {
                throw new ArgumentException("Comparing error arguments isn't a Product");
            }

            Products other = obj as Products;

            return Price.CompareTo(other.Price);
        }
    }
}
