using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double loan = double.Parse(Console.ReadLine());
            double cake = loan * 20 / 100;
            double drinks = cake * 55 / 100;
            double animator = loan / 3;
            Console.WriteLine(loan+cake+drinks+animator);
        }
    }
}