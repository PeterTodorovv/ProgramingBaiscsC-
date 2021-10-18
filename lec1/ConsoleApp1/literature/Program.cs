using System;

namespace literature
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine(pages / pagesPerHour / days);
        }
    }
}
