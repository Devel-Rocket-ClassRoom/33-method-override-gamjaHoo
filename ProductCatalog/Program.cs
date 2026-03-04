using System;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 상품 카탈로그 ===");
            Product[] products = new Product[]
            {
                new Electronics("노트북", 1500000, 24),
                new Clothing("청바지", 89000, 'M'),
                new Food("우유", 3500, "2026-06-15")
            };
            foreach(Product product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine(product.GetDescription());
            }
        }
    }
}