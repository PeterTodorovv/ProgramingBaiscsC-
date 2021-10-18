using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            while (totalSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int step = int.Parse(Console.ReadLine());
                    totalSteps += step;
                    break;
                }
                int steps = int.Parse(input);
                totalSteps += steps;
            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!\n{totalSteps-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
