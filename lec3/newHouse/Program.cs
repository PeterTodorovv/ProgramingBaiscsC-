using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalPrice = 0;

            switch (typeFlowers)
            {
                case "Roses":
                    if (count > 80)
                    {
                        finalPrice = (count*5)*0.9;
                    }
                    else
                    {
                        finalPrice = count * 5;
                    }
                    break;
                case "Dahlias":
                    if (count > 90)
                    {
                        finalPrice = (count * 3.8) * 0.85;
                    }
                    else
                    {
                        finalPrice = count * 3.8;
                    }
                    break;
                case "Tulips":
                    if (count > 80)
                    {
                        finalPrice = (count * 2.8) * 0.85;
                    }
                    else
                    {
                        finalPrice = count * 2.8;
                    }
                    break;
                case "Narcissus":
                    if (count < 120)
                    {
                        finalPrice = (count * 3) * 1.15;
                    }
                    else
                    {
                        finalPrice = count * 3;
                    }
                    break;
                case "Gladiolus":
                    if (count < 80)
                    {
                        finalPrice = (count * 2.5) * 1.2;
                    }
                    else
                    {
                        finalPrice = count * 2.5;
                    }
                    break;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {typeFlowers} and {(budget-finalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(finalPrice-budget):f2} leva more.");
            }
        }
    }
}
