using System;

namespace godzila
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine())*extras;
            double decor = budget * 0.1;


            if(extras > 150)
            {
                clothes *= 0.9;
            }
            double expenses = decor + clothes;
            if (budget < expenses)
            {
                double neededMoney = expenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(string.Format("{0:0.00}", neededMoney))} leva more.");
            }
            else
            {
                double  moneyLeft = budget - expenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(string.Format("{0:0.00}", moneyLeft))} leva left.");
            }

        }
    }
}
