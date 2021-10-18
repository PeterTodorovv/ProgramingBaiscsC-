using System;

namespace RToG
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(R*180/Math.PI));
        }
    }
}
