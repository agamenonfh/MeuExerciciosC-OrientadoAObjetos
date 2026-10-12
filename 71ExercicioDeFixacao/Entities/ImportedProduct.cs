using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        public List<ImportedProduct> importedProduct = new List<ImportedProduct>();
        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public void AddImportedProduct(ImportedProduct product)
        {
            importedProduct.Add(product);
        }
        public void RemoveImportedProduct(ImportedProduct product)
        {
            importedProduct.Remove(product);
        }
        double TotalPrice()
        {
            return Price + CustomFee;
        }
        override public string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomFee.ToString("F2") + ")";
        }

    }
}
