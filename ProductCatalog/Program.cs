using System;

Product[] products = new Product[3];
products[0] = new Electronics { Name = "노트북", Price = 1500000, Warranty = 24 };
products[1] = new Clothing { Name = "청바지", Price = 89000, Size = "M" };
products[2] = new Food { Name = "우유", Price = 3500, ExpirationDate = "2026-06-15" };

Console.WriteLine("=== 상품 카탈로그 ===");
foreach (var item in products)
{
    Console.WriteLine(item);
    Console.Write("\t->");
    item.GetDescription();
}


