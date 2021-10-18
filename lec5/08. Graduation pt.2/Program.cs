using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolClass = 1;
            double average = 0;
            int gradesUnder4 = 0;

            while (schoolClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;
                if (grade < 4)
                {
                    gradesUnder4++;
                    if (gradesUnder4 >= 2)
                    {
                        break;
                    }
                }

                schoolClass++;
            }
            if (gradesUnder4 >= 2)
                Console.WriteLine($"{name} has been excluded at {schoolClass-1} grade");
            else
                Console.WriteLine($"{name} graduated. Average grade: {(average / 12):f2}");

        }
    }
}
