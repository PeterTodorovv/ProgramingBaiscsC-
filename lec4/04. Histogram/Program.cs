using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalNumbers = int.Parse(Console.ReadLine());
            int lessthen200 = 0;
            int between200And399 = 0;
            int between400And599 = 0;
            int between600And799 = 0;
            int moreOr800 = 0;

            for (int i = 1; i <= totalNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    lessthen200++;
                }
                else if (number>= 200 && number <= 399)
                {
                    between200And399++;
                }
                else if (number >= 400 && number <= 599)
                {
                    between400And599++;
                }
                else if (number >= 600 && number <= 799)
                {
                    between600And799++;
                }
                else
                {
                    moreOr800++;
                }
            }
            Console.WriteLine($"{(lessthen200 / totalNumbers * 100):f2}%");
            Console.WriteLine($"{(between200And399 / totalNumbers * 100):f2}%");
            Console.WriteLine($"{(between400And599 / totalNumbers * 100):f2}%");
            Console.WriteLine($"{(between600And799 / totalNumbers * 100):f2}%");
            Console.WriteLine($"{(moreOr800 / totalNumbers * 100):f2}%");
        }
    }
}
