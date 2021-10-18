using System;

namespace jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Camp - {(budget*0.3):f2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Hotel - {(budget * 0.7):f2}");
                        break;
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Camp - {(budget * 0.4):f2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Hotel - {(budget * 0.8):f2}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {(budget * 0.9):f2}");
            }
        }
    }
}
