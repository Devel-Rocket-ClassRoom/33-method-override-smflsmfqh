using System;
using System.Collections.Generic;
using System.Text;

class Food : Product
{
    public string ExpirationDate { get; set; }
    public override string ToString()
    {
        return $"[{Name}] - \\{Price:N0} (유통기한: {ExpirationDate})";
    }
    public override void GetDescription()
    {
        Console.WriteLine("식품입니다. 냉장 보관하세요.");
    }
}