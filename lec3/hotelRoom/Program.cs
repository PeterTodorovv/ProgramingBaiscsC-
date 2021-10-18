using System;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = nights * 50;
                    priceApartment = nights * 65;

                    if (nights > 14)
                    {
                        priceStudio *= 0.7;
                        priceApartment *= 0.9;
                    }
                    else if (nights > 7)
                    {
                        priceStudio *=  0.95;
                    }

                    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                    break;
                case "September":
                case "June":
                    priceStudio = nights * 75.20;
                    priceApartment = nights * 68.70;

                    if (nights > 14)
                    {
                        priceStudio *= 0.8;
                        priceApartment *= 0.9;
                    }

                    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                    break;
                case "July":
                case "August":
                    priceStudio = nights * 76;
                    priceApartment = nights * 77;

                    if (nights > 14)
                    {
                        priceApartment *= 0.9;
                    }
                    Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                    break;
            }
        }
    }
}
