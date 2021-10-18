using System;

namespace skii
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine())-1;
            string typeRoom = Console.ReadLine();
            string feedback = Console.ReadLine();
            double totalCost = 0;

            switch (typeRoom){
                case "room for one person":
                    totalCost = 18.00 * days;
                    break;
                case "apartment":
                    if(days < 10)
                    {
                        totalCost = (25.00 * days)*0.7;
                    }
                    else if (days >=10 && days <= 15)
                    {
                        totalCost = (25.00 * days) * 0.65;
                    }
                    else
                    {
                        totalCost = (25.00 * days) * 0.5;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        totalCost = (35.00 * days) * 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalCost = (35.00 * days) * 0.85;
                    }
                    else
                    {
                        totalCost = (35.00 * days) * 0.8;
                    }
                    break;
            }
            if (feedback == "positive")
            {
                totalCost += totalCost * 0.25;

            }
            else
            {
                totalCost *= 0.9;
            }
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
