using System;

namespace even2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double totalMonay = (puzzles * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
            int totalToys = puzzles + dolls + bears + minions + trucks;
            if (totalToys >= 50)
                totalMonay *= 0.75;
            totalMonay *= 0.9;
            if (totalMonay >= cost)
            {
                Console.WriteLine($"Yes! {(totalMonay-cost):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(cost-totalMonay):f2} lv needed.");
            }
        }
    }
}
