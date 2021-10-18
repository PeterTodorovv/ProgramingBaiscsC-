using System;

namespace _6_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 1;
            int distance = 5_364;
            int everest = 8_848;
            while (days != 5)
            {
                string command = Console.ReadLine();
                if (command == "Yes")
                {
                    days++;
                }
                else if (command == "No")
                {
                    
                }
                else if (command == "END")
                {
                    break;
                }
                int distanceToday = int.Parse(Console.ReadLine());
                distance += distanceToday;
                if (distance >= everest)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    return;
                }
            }
            Console.WriteLine($"Failed!\n{distance}");
        }
    }
}
