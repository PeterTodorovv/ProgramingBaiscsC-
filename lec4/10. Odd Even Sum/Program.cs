using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbner = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    firstSum += numbner;
                }
                else
                {
                    secondSum += numbner;
                }
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes\nSum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(firstSum - secondSum)}");
            }
        }
    }
}
