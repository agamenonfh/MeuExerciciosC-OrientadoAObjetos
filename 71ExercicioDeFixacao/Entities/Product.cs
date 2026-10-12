using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        List<Product> products = new List<Product>();

        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
        override public string ToString()
        {
            return PriceTag();
        }

    }
}
