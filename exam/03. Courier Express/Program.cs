using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double totalCost = 0;

            switch (serviceType)
            {
                case "standard":
                    if(weight< 1)
                        totalCost = distance * 0.03;
                    else if(weight >= 1 && weight < 10)
                        totalCost = distance * 0.05;
                    else if (weight >= 10 && weight <= 40)
                        totalCost = distance * 0.10;
                    else if (weight > 40 && weight <= 90)
                        totalCost = distance * 0.15;
                    else if (weight > 90 && weight <= 150)
                        totalCost = distance * 0.20;
                    break;
                case "express":
                    if (weight < 1)
                        totalCost = distance * 0.03 + (0.03*0.80*weight * distance);
                    else if (weight >= 1 && weight < 10)
                        totalCost = distance * 0.05 + (0.05 * 0.40 * weight * distance);
                    else if (weight >= 10 && weight <= 40)
                        totalCost = distance * 0.10 + (0.1 * 0.05 * weight * distance);
                    else if (weight > 40 && weight <= 90)
                        totalCost = distance * 0.15 + (0.15 * 0.02 * weight * distance);
                    else if (weight > 90 && weight <= 150)
                        totalCost = distance * 0.20 + (0.20 * 0.01 * weight * distance);
                    break;

            }
             Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalCost:f2} lv.");
        }
    }
}
