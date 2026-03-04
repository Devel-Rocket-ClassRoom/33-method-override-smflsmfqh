using System;
using System.Collections.Generic;
using System.Text;

class Car : Vehicle
{
    public Car()
    {
        Speed = 120;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}
