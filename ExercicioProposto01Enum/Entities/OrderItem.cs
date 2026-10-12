using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto01Enum.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();
        public Product Product { get; set; }
        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        override public string ToString()
        {
            return Product.Name 
                +", $" 
                + Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) 
                + ", Quantity: " 
                + Quantity 
                + ", Subtotal: " 
                + SubTotal().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
