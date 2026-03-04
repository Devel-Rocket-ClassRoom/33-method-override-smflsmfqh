using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public string Name {  get; set; }
    public int Price { get; set; }
    public override string ToString()
    {
        return $"[{Name}] - \\{Price:N0}";
    }
    public virtual void GetDescription()
    {
        Console.WriteLine("제품 설명입니다.");
    }
}
