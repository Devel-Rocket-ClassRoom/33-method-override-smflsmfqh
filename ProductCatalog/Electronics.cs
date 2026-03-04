using System;
using System.Collections.Generic;
using System.Text;

class Electronics : Product
{
    public int Warranty { get; set; }
    public override string ToString()
    {
        return $"[{Name}] - \\{Price:N0} (보증: {Warranty}개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine("전자기기입니다. 취급에 주의하세요.");
    }
}