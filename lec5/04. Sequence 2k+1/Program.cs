using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int number = 1;

            while (firstNumber >= number)
            {
                Console.WriteLine(number);
                number = number * 2 + 1; 
            }
        }
    }
}
