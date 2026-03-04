using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    internal class Electronics : Product
    {
        private int Warranty;
        public Electronics(string name, int price, int warranty) : base(name, price)
        {
            Warranty = warranty;
        }

        public override string ToString()
        {
            return base.ToString() + $" (보증: {Warranty}개월)";
        }
        public override string GetDescription()
        {
            return "  -> 전자기기입니다. 취급에 주의하세요.";
        }
    }
}
