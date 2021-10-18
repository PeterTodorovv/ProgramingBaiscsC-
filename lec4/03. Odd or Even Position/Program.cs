using System;

namespace _03._Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            double oddMax = int.MinValue;
            double oddMin = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if(i % 2== 0)
                {
                    evenSum += number;
                    if (evenMin > number)
                        evenMin = number;
                    if (evenMax < number)
                        evenMax = number;
                }
                else
                {
                    oddSum += number;
                    if (oddMin > number)
                        oddMin = number;
                    if (oddMax < number)
                        oddMax = number;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != int.MaxValue)
                Console.WriteLine($"OddMin={oddMin:f2},");
            else
                Console.WriteLine($"OddMin=No,");
            if (oddMax != int.MinValue)
                Console.WriteLine($"OddMax={oddMax:f2},");
            else
                Console.WriteLine($"OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin != int.MaxValue)
                Console.WriteLine($"EvenMin={evenMin:f2},");
            else
                Console.WriteLine($"EvenMin=No,");
            if (evenMax != int.MinValue)
                Console.WriteLine($"EvenMax={evenMax:f2}");
            else
                Console.WriteLine($"EvenMax=No");
        }
    }
}
