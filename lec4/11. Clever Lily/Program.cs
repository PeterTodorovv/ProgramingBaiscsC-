using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double priceOfToys = double.Parse(Console.ReadLine());
            double totalMonay = 0;

            for(int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMonay += 10 * (i / 2) -1;
                }
                else
                {
                    totalMonay += priceOfToys;
                }
            }
            if (totalMonay >= washingMachine)
            {
                Console.WriteLine($"Yes! {(totalMonay-washingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachine-totalMonay):f2}");
            }
        }
    }
}
