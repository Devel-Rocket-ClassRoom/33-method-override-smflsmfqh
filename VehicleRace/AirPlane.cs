using System;
using System.Collections.Generic;
using System.Text;

class Airplane : Vehicle
{
    public Airplane()
    {
        Speed = 900;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}