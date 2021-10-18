using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;

            for(int x = start; x <= end; x++)
            {
                for (int y = start; y <= end; y++)
                {
                    combinations++;
                    if (x + y == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
