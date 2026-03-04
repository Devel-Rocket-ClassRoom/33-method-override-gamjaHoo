using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    internal class Product
    {
        private string Name;
        private int Price;

        public Product(string name, int price)
        {
            Name = name; Price = price; 
        }
        public override string ToString()
        {
            return $"[{Name}] - \\[{Price:N0}]";
        }
        public virtual string GetDescription()
        {
            return "기본설명";
        }
    }
}
