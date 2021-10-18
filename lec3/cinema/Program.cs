using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (typeProjection)
            {
                case "Premiere":
                    Console.WriteLine($"{(rows*columns*12):f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(rows * columns * 7.5):f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(rows * columns * 5):f2} leva");
                    break;
            }
        }
    }
}
