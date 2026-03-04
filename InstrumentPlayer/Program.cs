using System;

Instrument[] inst = new Instrument[3];
inst[0] = new Piano();
inst[1] = new Guitar();
inst[2] = new Drum();

Console.WriteLine("=== 악기 연주회 ===");
foreach (Instrument inst2 in inst)
{
    inst2.Play();
    inst2.Tune();
    Console.WriteLine();
}