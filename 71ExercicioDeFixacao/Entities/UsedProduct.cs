using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        List<UsedProduct> usedProducts = new List<UsedProduct>();

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        override public string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2") + " (Manufactured Date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
