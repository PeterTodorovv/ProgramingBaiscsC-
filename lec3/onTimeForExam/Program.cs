using System;

namespace onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingHour = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());
            int comingHour = int.Parse(Console.ReadLine());
            int comingMinutes = int.Parse(Console.ReadLine());

            int totalStartingMinutes = startingHour * 60 + startingMinutes;
            int totalComingMinutes = comingHour * 60 + comingMinutes;
            if (totalStartingMinutes > totalComingMinutes)
            {
                int diff = totalStartingMinutes - totalComingMinutes;
                if (diff <= 30)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("Early");
                }
                if (diff >= 60)
                {
                    Console.WriteLine($"{diff / 60}:{diff % 60:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else if (totalComingMinutes > totalStartingMinutes)
            {
                int diff = totalComingMinutes - totalStartingMinutes;
                Console.WriteLine("Late");
                if (diff >= 60)
                {
                    Console.WriteLine($"{diff / 60}:{(diff % 60):d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{diff} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}
