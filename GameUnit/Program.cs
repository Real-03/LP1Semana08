using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit soldier = new MilitaryUnit(2, 10, 4);
            SettlerUnit settler = new SettlerUnit();

            Console.WriteLine("=== Soldier ===");
            Console.WriteLine(soldier.Move());
            Console.WriteLine($"Health: {soldier.Health}");
            Console.WriteLine($"Cost: {soldier.Cost}");

            Console.WriteLine("\n=== Settler ===");
            Console.WriteLine(settler.Move());
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Cost: {settler.Cost}");
        }
    }
}
