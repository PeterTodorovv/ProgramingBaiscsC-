using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int totalSpace = height * width * lenght;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxes = int.Parse(command);
                totalSpace -= boxes;
                if (totalSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }

            if (totalSpace >= 0)
            {
                Console.WriteLine($"{totalSpace} Cubic meters left.");
            }
        }
    }
}
