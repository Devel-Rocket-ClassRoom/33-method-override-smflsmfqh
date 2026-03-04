using System;
using System.Collections.Generic;
using System.Text;

class Drum : Instrument
{
    public Drum() : base("드럼") { }
    public override void Play()
    {
        Console.WriteLine($"🥁 {_name}을 두드립니다 - 둥둥둥~");
    }

}
