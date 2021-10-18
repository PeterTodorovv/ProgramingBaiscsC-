using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int daysSpending = 0;
            int totalDays = 0;

            while (true)
            {
                totalDays++;
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if(action == "spend")
                {
                    budget -= money;
                    if (budget < 0)
                        budget = 0;
                    daysSpending++;
                    if (daysSpending == 5)
                    {
                        Console.WriteLine($"You can't save the money.\n{totalDays}");
                        break;
                    }    
                }
                else if (action == "save")
                {
                    budget += money;
                    daysSpending = 0;
                    if (budget >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        break;
                    }
                }
            }
        }
    }
}
