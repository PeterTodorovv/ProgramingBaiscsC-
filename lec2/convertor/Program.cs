using System;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if(input == "mm" && output == "m")
            {
                Console.WriteLine(String.Format("{0:0.000}", number /1000));
            }
            else if (input == "mm" && output == "cm")
            {
                Console.WriteLine(String.Format("{0:0.000}", number / 10));
            }
            else if (input == "cm" && output == "m")
            {
                Console.WriteLine(String.Format("{0:0.000}", number / 100));
            }
            else if (input == "cm" && output == "mm")
            {
                Console.WriteLine(String.Format("{0:0.000}", number * 10));
            }
            else if (input == "m" && output == "cm")
            {
                Console.WriteLine(String.Format("{0:0.000}", (number * 100)));
            }
            else if (input == "m" && output == "mm")
            {
                Console.WriteLine(String.Format("{0:0.000}", number * 1000));
            }
        }
    }
}
