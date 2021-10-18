using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int surprices = int.Parse(Console.ReadLine());

            int totalArticules = loveLetters + roses + keychains + cartoons + surprices;
            double totalMoney = loveLetters * 0.60 + roses * 7.20 + keychains * 3.60 + cartoons * 18.20 + surprices * 22;
            if (totalArticules >= 25)
                totalMoney *= 0.65;

            totalMoney *= 0.9;

            if (totalMoney >= moneyNeeded)
                Console.WriteLine($"Yes! {(totalMoney - moneyNeeded):f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {(moneyNeeded-totalMoney):f2} lv needed.");
        }
    }
}
