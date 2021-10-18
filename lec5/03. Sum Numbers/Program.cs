using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;

            while (totalSum < firstNumber)
            {
                int number = int.Parse(Console.ReadLine());
                totalSum += number;
            }
            Console.WriteLine(totalSum);
        }
    }
}
