using System;

namespace lec5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int mins =0; mins < 60; mins++)
                {
                    Console.WriteLine($"{i}:{mins}");
                }
            }
        }
    }
}
