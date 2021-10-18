using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int totalCoins = 0;

            while (change > 0)
            {
                if (change - 2 >= 0)
                {
                    totalCoins++;
                    change -= 2;
                }
                else if (change - 1 >= 0)
                {
                    totalCoins++;
                    change -= 1;
                }
                else if (change - 0.5 >= 0)
                {
                    totalCoins++;
                    change -= 0.5;
                }
                else if (change - 0.2 >= 0)
                {
                    totalCoins++;
                    change -= 0.2;
                }
                else if (change - 0.1 >= 0)
                {
                    totalCoins++;
                    change -= 0.1;
                }
                else if (change - 0.05 >= 0)
                {
                    totalCoins++;
                    change -= 0.05;
                }
                else if (change - 0.02 >= 0)
                {
                    totalCoins++;
                    change -= 0.02;
                }
                else if (change - 0.01 >= 0)
                {
                    totalCoins++;
                    change -= 0.01;
                }
                change = Math.Round(change,2);
            }
            Console.WriteLine(totalCoins);
        }
    }
}
