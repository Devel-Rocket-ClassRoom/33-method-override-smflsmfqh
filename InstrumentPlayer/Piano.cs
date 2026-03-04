using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

class Piano : Instrument
{
    public Piano() : base("피아노") { }
    public override void Play()
    {
        Console.WriteLine($"🎹 {_name} 건반을 누릅니다 - 딩동댕~");
    }

    public override void Tune()
    {
        Console.WriteLine($"{_name} 현을 조율합니다.");
    }
}
