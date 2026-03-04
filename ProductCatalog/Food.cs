using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    internal class Food : Product
    {
        private string ExpirationDate;
        public Food(string name, int price, string expiration) : base(name, price)
        {
            ExpirationDate = expiration;
        }

        public override string ToString()
        {
            return base.ToString() + $" (유통기한: {ExpirationDate})";
        }
        public override string GetDescription()
        {
            return "  -> 식품입니다. 냉장 보관하세요.";
        }
    }
}
