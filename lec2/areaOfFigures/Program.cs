using System;

namespace areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();
            if (typeFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side*side), 3));
            }
            else if(typeFigure== "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side1 * side2), 3));
            }
            else if (typeFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((radius * radius * Math.PI), 3));

            }
            else if(typeFigure== "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side1 * side2/2), 3));
            }
        }
    }
}
