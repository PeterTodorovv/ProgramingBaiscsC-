using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination!="End")
            {
                double budget=0;
                double budgetNeeded = double.Parse(Console.ReadLine());
                while (budget < budgetNeeded)
                {
                    budget += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
