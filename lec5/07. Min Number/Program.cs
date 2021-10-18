using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string commmand = Console.ReadLine();

            while (commmand != "Stop")
            {
                int number = int.Parse(commmand);
                if (number < minNumber)
                    minNumber = number;
                commmand = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
