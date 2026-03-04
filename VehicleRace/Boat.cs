using System;
using System.Collections.Generic;
using System.Text;

class Boat : Vehicle
{
    public Boat()
    {
        Speed = 60;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}