using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jMembers = int.Parse(Console.ReadLine());
            double averageGrade = 0;
            int totalPresenations = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                    break;
                totalPresenations++;
                double totalGrade = 0;
                for (int i = 1; i <= jMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                }
                Console.WriteLine($"{command} - {(totalGrade/jMembers):f2}.");
                averageGrade += totalGrade / jMembers;
            }
            Console.WriteLine($"Student's final assessment is {(averageGrade/totalPresenations):f2}.");
        }
    }
}
