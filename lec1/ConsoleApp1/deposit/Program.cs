using System;

namespace deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double total = sum + months * ((sum* (interest/100))/12);

            Console.WriteLine(total);
        }
    }
}
