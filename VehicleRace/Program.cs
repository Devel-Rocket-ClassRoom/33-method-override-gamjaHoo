using System;

namespace VehicleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 경주 시작! ===");
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car("스포츠카"),
                new Airplane("보잉747"),
                new Boat("요트")
            };
            foreach(var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}