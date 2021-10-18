using System;

namespace seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int athlete1 = int.Parse(Console.ReadLine());
            int athlete2 = int.Parse(Console.ReadLine());
            int athlete3 = int.Parse(Console.ReadLine());

            int total = athlete1 + athlete2 + athlete3;
            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
