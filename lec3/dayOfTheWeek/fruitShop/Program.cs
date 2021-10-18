﻿using System;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine($"{(quantity * 2.50):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(quantity * 1.20):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(quantity * 0.85):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(quantity * 1.45):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(quantity * 2.70):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(quantity * 5.5):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(quantity * 3.85):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine($"{(quantity * 2.70):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(quantity * 1.25):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(quantity * 0.9):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(quantity * 1.6):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(quantity * 3):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(quantity * 5.6):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(quantity * 4.2):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
