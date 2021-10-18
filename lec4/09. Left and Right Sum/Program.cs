using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 1; i<=n*2; i++)
            {
                int numbner = int.Parse(Console.ReadLine());
                if (i <= n)
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
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum-secondSum)}");
            }
        }
    }
}
