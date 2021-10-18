using System;

namespace swimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double IvansTime = timeForMeter * meters + (Math.Floor(meters / 15) * 12.5);
            if (seconds > IvansTime)
            {     
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvansTime:f2} seconds.");
            }
            else
            { 
                double diff = IvansTime - seconds;
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }

        }
    }
}