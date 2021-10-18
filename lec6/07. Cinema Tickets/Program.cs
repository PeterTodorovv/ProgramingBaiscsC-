using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTikets = 0;
            double totalStudent = 0;
            double totalStandard = 0;
            double totalKids = 0;

            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                    break;
                double tiketsBoguht = 0;

                int capacity = int.Parse(Console.ReadLine());
                while(capacity> tiketsBoguht)
                {
                    string tiketType = Console.ReadLine();
                    if (tiketType == "End")
                        break;
                    else if (tiketType == "standard")
                        totalStandard++;
                    else if (tiketType == "kid")
                        totalKids++;
                    else if (tiketType == "student")
                        totalStudent++;
                    totalTikets++;
                    tiketsBoguht++;
                }
                Console.WriteLine($"{movieName} - {(tiketsBoguht/capacity*100):f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTikets}");
            Console.WriteLine($"{(totalStudent/totalTikets*100):f2}% student tickets.");
            Console.WriteLine($"{(totalStandard / totalTikets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(totalKids/ totalTikets * 100):f2}% kids tickets.");
        }
    }
}
