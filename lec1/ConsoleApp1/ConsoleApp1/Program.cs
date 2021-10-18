using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 7.61;
            double fild = double.Parse(Console.ReadLine());
            double total = fild * price;
            double discont = Math.Round(total * 0.18, 2);

            Console.WriteLine($"The final price is: {total-discont} lv.");
            Console.WriteLine($"The discount is: {discont} lv.");
        }
    }
}
