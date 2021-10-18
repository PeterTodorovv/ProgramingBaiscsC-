using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cardsForTransport = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double sumForPerson = nights * 20 + cardsForTransport * 1.60 + tickets * 6;
            double totalSum = (sumForPerson * people) * 1.25;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
