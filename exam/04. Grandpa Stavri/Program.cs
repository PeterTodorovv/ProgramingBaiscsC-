using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalRakia = 0;
            double alcohol = 0;
            

            for(int day = 1; day<= days; day++)
            {
                double rakiaToday = double.Parse(Console.ReadLine());
                totalRakia += rakiaToday;
                alcohol += rakiaToday * (double.Parse(Console.ReadLine()));
            }
            alcohol /= totalRakia;

            Console.WriteLine($"Liter: {totalRakia:f2}");
            Console.WriteLine($"Degrees: {alcohol:f2}");

            if (alcohol < 38)
                Console.WriteLine("Not good, you should baking!");
            else if (alcohol > +38 && alcohol <= 42)
                Console.WriteLine("Super!");
            else
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}
