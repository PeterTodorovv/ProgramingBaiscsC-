using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int devidableBy2 = 0;
            int devidableBy3 = 0;
            int devidableBy4 = 0;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    devidableBy2++;
                if (number % 3 == 0)
                    devidableBy3++;
                if (number % 4 == 0)
                    devidableBy4++;
            }
            Console.WriteLine($"{(devidableBy2/n*100):f2}%");
            Console.WriteLine($"{(devidableBy3/n*100):f2}%");
            Console.WriteLine($"{(devidableBy4/n*100):f2}%");

        }
    }
}
