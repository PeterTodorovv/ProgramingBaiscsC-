using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHeight = 5364;
            int everest = 8848;
            int days = 1;

            while (days != 5)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else if (command == "Yes")
                {
                    days++;
                }
                currentHeight += int.Parse(Console.ReadLine());
                
                if (everest <= currentHeight)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    return;
                }


            }
            Console.WriteLine("Failed!");
            Console.WriteLine(currentHeight);
        }
    }
}
