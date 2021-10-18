using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <=n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                totalSum += number;

            }
            Console.WriteLine(totalSum);
        }
    }
}
