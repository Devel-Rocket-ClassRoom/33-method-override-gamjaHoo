using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRace
{
    internal class Vehicle
    {
        protected string Name;
        protected int Speed;

        public Vehicle(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"[{Name}](이)가 이동합니다. 속도: {Speed}km/h");
        }
    }
}
