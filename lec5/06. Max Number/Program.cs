using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string commmand = Console.ReadLine();

            while (commmand!= "Stop")
            {
                int number = int.Parse(commmand);
                if (number > maxNumber)
                    maxNumber = number;
                commmand = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
