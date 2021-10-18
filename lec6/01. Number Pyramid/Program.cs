using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int printedN = 1;

            for (int rows = 1; printedN <= n; rows++)
            {
                Console.WriteLine();
                for(int i = 1; i <= rows; i++)
                {
                    if (printedN > n)
                        return;
                    Console.Write(printedN + " ");
                    printedN++;
                }
            }
        }
    }
}
