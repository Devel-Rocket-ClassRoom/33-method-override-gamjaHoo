using System;

namespace InstrumentPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] instruments = new Instrument[]
            {
                new Piano("피아노"),
                new Guitar("기타"),
                new Drum("드럼")
            };

            Console.WriteLine("=== 악기 연주회 ===");
            foreach(Instrument instr in instruments)
            {
                instr.Tune();
                instr.Play();
                Console.WriteLine();
            }
        }
    }
}