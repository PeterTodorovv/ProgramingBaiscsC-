using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            int totalSum = 0;
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                totalSum += number;
            }
            totalSum -= maxNumber;
            if (maxNumber == totalSum)
            {
                Console.WriteLine($"Yes\nSum = {maxNumber}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = { Math.Abs(totalSum-maxNumber)}");
            }
        }
    }
}
