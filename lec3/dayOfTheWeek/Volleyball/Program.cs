using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - h;
            double gamesInSofia = weekendsInSofia * 3 / 4.0;
            double gamesDuringHolidays = p * 2 / 3.0;
            double totalGames = gamesInSofia + h + gamesDuringHolidays;
            
            if (typeYear == "leap")
            {
                totalGames *= 1.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
