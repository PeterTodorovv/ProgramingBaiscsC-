using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double money = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "NoMoreMoney")
                    break;
                money = double.Parse(command);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                total += money;
            }
            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
