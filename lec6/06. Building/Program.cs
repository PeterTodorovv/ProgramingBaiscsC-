using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine()) - 1;

            for (int a = 0; a <= rooms; a++)
                Console.Write($"L{floors}{a} ");
            for (int f = floors-1; f>=1; f--)
            {
                Console.WriteLine();
                if (f % 2 == 1)
                {
                    for(int n=0; n<= rooms; n++)
                        Console.Write($"A{f}{n} ");
                }
                else
                {
                    for (int n = 0; n <= rooms; n++)
                        Console.Write($"O{f}{n} ");
                }
            }
        }
    }
}
