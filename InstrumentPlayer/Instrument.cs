using System;
using System.Collections.Generic;
using System.Text;

class Instrument
{
    protected string _name;
    public Instrument(string name)
    {
        _name = name;
    }

    public virtual void Play()
    {
        Console.WriteLine($"{_name}을(를) 연주합니다.");
    }

    public virtual void Tune()
    {
        Console.WriteLine($"{_name}을(를) 조율합니다.");
    }
}
