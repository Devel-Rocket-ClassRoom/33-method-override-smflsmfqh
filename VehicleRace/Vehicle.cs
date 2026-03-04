using System;
using System.Collections.Generic;
using System.Text;

class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public virtual void Move()
    {
        Console.WriteLine($"{Name}이(가) 이동합니다. 속도: {Speed}km/h");
    }
}